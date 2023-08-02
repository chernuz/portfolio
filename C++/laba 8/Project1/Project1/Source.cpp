#include <windows.h>
#include <string>
//#include <time.h>

LRESULT CALLBACK WndProc(HWND, UINT, WPARAM, LPARAM);
HINSTANCE hInst;
int WINAPI WinMain(HINSTANCE hInstance, HINSTANCE hPrevInstance,
    PSTR szCmdLine, int iCmdShow)
{
    static char szAppName[] = "HelloWin";
    HWND        hwnd;
    MSG         msg;
    WNDCLASSEX  wndclass;

    wndclass.cbSize = sizeof(wndclass);
    wndclass.style = CS_HREDRAW | CS_VREDRAW;
    wndclass.lpfnWndProc = WndProc;
    wndclass.cbClsExtra = 0;
    wndclass.cbWndExtra = 0;
    wndclass.hInstance = hInstance;
    wndclass.hIcon = LoadIcon(NULL, IDI_APPLICATION);
    wndclass.hCursor = LoadCursor(NULL, IDC_ARROW);
    wndclass.hbrBackground = (HBRUSH)GetStockObject(WHITE_BRUSH);
    wndclass.lpszMenuName = NULL;
    wndclass.lpszClassName = szAppName;
    wndclass.hIconSm = LoadIcon(NULL, IDI_APPLICATION);

    RegisterClassEx(&wndclass);

    hwnd = CreateWindow(szAppName,        // 
        "Лаба 7",   // 
        WS_OVERLAPPEDWINDOW,     // 
        CW_USEDEFAULT,           // 
        CW_USEDEFAULT,           // 
        900,           // 
        500,           // 
        NULL,                    // 
        NULL,                    // 
        hInstance,               // 
        NULL);		   // 


    ShowWindow(hwnd, iCmdShow);
    UpdateWindow(hwnd);

    while (GetMessage(&msg, NULL, 0, 0))
    {
        TranslateMessage(&msg);
        DispatchMessage(&msg);
    }
    return msg.wParam;
}

#define BTN_WIDTH        200
#define BTN_HEIGHT       30

static bool timerIsOn = false;
int x_smesh = 0, y_smesh = 0, count = 0;
LRESULT CALLBACK WndProc(HWND hwnd, UINT iMsg, WPARAM wParam, LPARAM lParam)
{
    HDC         hdc;
    PAINTSTRUCT ps;
    RECT        rect;
    static HWND  hwndButton1, hwndButton2, hwndButton3;
    static char txt[64] = "";
    int loword, hiword;
    static int fpic = 0;
    static HPEN hpen;
    static HBRUSH hbrush;

    switch (iMsg)
    {
    case WM_CREATE:
        //srand(time(0));
        SetTimer(hwnd, 1, 70, NULL);
        x_smesh = 0; y_smesh = 0;
        hdc = GetDC(hwnd);
        hwndButton1 = CreateWindow("button", "Нарисовать рисунок",
            WS_CHILD | WS_VISIBLE | BS_PUSHBUTTON,
            100, 50, BTN_WIDTH, BTN_HEIGHT,
            hwnd, (HMENU)1, hInst, NULL);

        hwndButton2 = CreateWindow("button", "Очистить экран",
            WS_CHILD | WS_VISIBLE | BS_PUSHBUTTON,
            325, 50, BTN_WIDTH, BTN_HEIGHT,
            hwnd, (HMENU)2, hInst, NULL);

        hwndButton3 = CreateWindow("button", "Фамилия разработчкиа",
            WS_CHILD | WS_VISIBLE | BS_PUSHBUTTON,
            550, 50, BTN_WIDTH, BTN_HEIGHT,
            hwnd, (HMENU)3, hInst, NULL);

        return 0;
    case WM_COMMAND:
        //hpen = CreatePen(PS_SOLID, 10, RGB(rand() % 256, rand() % 256, rand() % 256));
        //hbrush = CreateSolidBrush(RGB(rand() % 256, rand() % 256, rand() % 256));
        loword = LOWORD(wParam);
        hiword = HIWORD(wParam);
        switch (loword) {
        case 1:
            fpic = 1;
            break;
        case 2:
            fpic = 2;
            break;
        case 3:
            strcpy_s(txt, "Чернавкин Артемий ИУ3-21Б Вариант 6");
            fpic = 3;
            break;
        default:	strcpy_s(txt, "Неизвестно что"); break;
        }
        InvalidateRect(hwnd, NULL, TRUE);
        return 0;

    case WM_PAINT:
        hdc = BeginPaint(hwnd, &ps);
        GetClientRect(hwnd, &rect);
        //TextOut(hdc, 100, 300, txt, strlen(txt));
        //SelectObject(hdc, hbrush);
        //SelectObject(hdc, hpen);
        if (timerIsOn)
        {
            switch ((count / 5) % 4)
            {
            case 0:
                x_smesh += 5;
                break;
            case 1:
                y_smesh += 5;
                break;
            case 2:
                x_smesh -= 5;
                break;
            case 3:
                y_smesh -= 5;
                break;
            }
            count++;
        }
        switch (fpic) {
        case 1:
            SelectObject(hdc, CreateSolidBrush(RGB(153, 51, 0)));
            SelectObject(hdc, CreatePen(PS_SOLID, 10, RGB(153, 51, 0)));
            Rectangle(hdc, 425, 250, 475, 400);
            SelectObject(hdc, CreateSolidBrush(RGB(255, 165, 0)));
            SelectObject(hdc, CreatePen(PS_SOLID, 10, RGB(195, 88, 23)));
            Ellipse(hdc, 350+x_smesh, 200+y_smesh, 450+x_smesh, 250 + y_smesh);
            Ellipse(hdc, 450+x_smesh, 200 + y_smesh, 550+x_smesh, 250 + y_smesh);
            Ellipse(hdc, 400+x_smesh, 175 + y_smesh, 500+x_smesh, 225 + y_smesh);
            Ellipse(hdc, 400+x_smesh, 225 + y_smesh, 500+x_smesh, 275 + y_smesh);
            //Rectangle(hdc, 300, 100, 800, 400);
            break;
        case 2:
            //Ellipse(hdc, 300, 100, 800, 400);
            break;
        case 3:
            TextOut(hdc, 300, 200, txt, strlen(txt));
            break;
        }



        EndPaint(hwnd, &ps);
        return 0;

    case WM_GETMINMAXINFO:
    {
        MINMAXINFO* pInfo = (MINMAXINFO*)lParam;
        POINT ptMin = { 900, 500 };
        POINT ptMax = { 1920, 1080 };
        pInfo->ptMinTrackSize = ptMin;
        pInfo->ptMaxTrackSize = ptMax;
        return 0;
    }

    case WM_LBUTTONDOWN:
        timerIsOn = true;
        return 0;

    case WM_RBUTTONDOWN:
        timerIsOn = false;
        return 0;

    case WM_TIMER:
        InvalidateRect(hwnd, 0, TRUE);
        return 0;


    case WM_DESTROY:
        PostQuitMessage(0);
        return 0;
    }



    return DefWindowProc(hwnd, iMsg, wParam, lParam);
}
