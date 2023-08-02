#include <iostream>
#include <string.h>
#include <malloc.h>
#include <fstream>

using namespace std;

const string DefaultName = "NoName";
const int DefaultGrade = 0;

struct Node
{
public:
    Node *next = nullptr;
    Node *prev = nullptr;
    string name;
    int grade1;
    int grade2;
    int grade3;
    int summ;

    Node(): next(nullptr), prev(nullptr), name(DefaultName), grade1(DefaultGrade), grade2(DefaultGrade), grade3(DefaultGrade), summ(DefaultGrade){};

    //Node(string s, int g1, int g2, int g3): next(nullptr), prev(nullptr), grade1(g1), grade2(g2), grade3(g3){};

    /*Node(string s): next(nullptr), prev(nullptr)
    {
        char * buf = new char[s.length()];

        strcpy(buf, s.c_str());
        string tempName = "";
        int i=0;
        while(buf[i]!=' ' && buf[i]!=0)
        {
            tempName += buf[i];

            cout<<"������� "<<(int)buf[i]<<endl;
            i++;
        }
        name = tempName;
        i++;
        int tempGrade=0;
        while(isdigit(buf[i]))
        {
            tempGrade = tempGrade*10 + buf[i]-48;
            i++;
        }
        i++;
        grade1 = tempGrade;
        tempGrade=0;
        while(isdigit(buf[i]!=' '))
        {
            tempGrade = tempGrade*10 + buf[i]-48;
            i++;
        }
        i++;
        grade2 = tempGrade;
        tempGrade=0;
        while(isdigit(buf[i]!=' '))
        {
            tempGrade = tempGrade*10 + buf[i]-48;
            i++;
        }
        grade3 = tempGrade;
    }*/

    ~Node(){};

    void Output()
    {
        cout<<name<<" "<<grade1<<" "<<grade2<<" "<<grade3<< " "<< summ;
    }
};

struct List
{
    Node *first, *last;

public:

    List(): first(nullptr), last(nullptr){};

    ~List()
    {
        while (first)
        {
            last = first->next;
            delete first;
            first = last;
        }
    }

    bool is_empty()
    {
        return first == nullptr;
    }

    void push_back(Node *newNode)
    {
        if(is_empty())
        {
            first = newNode;
            last = newNode;
            newNode->prev = nullptr;
        }
        else
        {
            last->next = newNode;
            newNode->prev = last;
            last = newNode;
        }
    }

    void modifiedPush_back(Node *newNode)
    {
        if(is_empty())
        {
            first = newNode;
            last = newNode;
            newNode->prev = nullptr;
        }
        else
        {
            Node *tempEl = first;
            while(tempEl && (tempEl->summ > newNode->summ))
            {
                tempEl = tempEl->next;
            }
            if(tempEl!=nullptr && tempEl->summ == newNode->summ && strcmp((tempEl->name).c_str(), (newNode->name).c_str())<0)
            {
                tempEl = tempEl ->next;
            }
            //� tempEl ������� �������, �� ����� �������� ���� ��������� �����
            if(tempEl == first)
            {
                first = newNode;
                tempEl->prev = newNode;
            }
            if(tempEl == nullptr)
            {
                newNode->prev = last;
                last->next = newNode;
                last = newNode;
            }
            else
            {
                newNode->prev = tempEl->prev;
                if(newNode->prev != first)
                    (newNode->prev)->next = newNode;
                tempEl->prev = newNode;
            }
            newNode->next = tempEl;
        }
    }

    void Output()
    {
        if(!is_empty())
        {
            Node *currentEl = first;
            while(currentEl!=nullptr)
            {
                currentEl->Output();
                currentEl=currentEl->next;
                cout<<endl;
            }
        }
        else
        {
            cout<<"List is empty"<<endl;
        }
    }

    Node* operator[] (const int index)
    {
        if (is_empty())
            return nullptr;
        Node *temp = first;
        for(int i=0; i<index; i++)
        {
            temp=temp->next;
            if(temp==nullptr)
                return nullptr;
        }
        return temp;
    }

    int size()
    {
        int counter = 0;
        Node *temp = first;
        while (temp!=nullptr)
        {
            temp=temp->next;
            counter++;
        }
        return counter;
    }
};

int main()
{
    setlocale(LC_ALL, "Rus");
    List listik;
    ifstream fin;
    fin.exceptions(ifstream::badbit| ifstream::failbit);
    try
    {
        fin.open("1.txt");
        string tempdata;
        int tempint;
        while (!fin.eof())
        {
            Node *temp = new Node;
            fin>>tempdata;
            temp->name = tempdata;
            fin>>tempint;
            temp->grade1 = tempint;
            fin>>tempint;
            temp->grade2 = tempint;
            fin>>tempint;
            temp->grade3 = tempint;
            temp->summ=temp->grade1+temp->grade2+temp->grade3;
            listik.modifiedPush_back(temp);
        }
        fin.close();
    }
    catch(ifstream::failure ex)
    {
        cout<<"������ 1!"<<endl<<ex.what()<<endl;
        exit(1);
    }
    int n = listik.size();
    FILE *f;
    f = fopen("baza.bin", "a");
    for (int i=0; i<n; i++)
    {
        fwrite(&listik, sizeof listik[i], 1, f);
    }
    fclose(f);
    listik.Output();
}
