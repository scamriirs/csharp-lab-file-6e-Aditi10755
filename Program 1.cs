#include <iostream>
#include <string>
using namespace std;

class Person {
private:
    string name;
    int age;

public:
    Person() {
        name = "Unknown";
        age = 0;
        cout << "Default constructor called" << endl;
    }

    Person(string personName, int personAge) {
        name = personName;
        age = personAge;
        cout << "Parameterized constructor called" << endl;
    }

    Person(string personName) {
        name = personName;
        age = 18; // Default age
        cout << "Constructor with default parameters called" << endl;
    }

    void displayInfo() {
        cout << "Name: " << name << ", Age: " << age << endl;
    }
};

int main() {
    Person person1;
    person1.displayInfo();

    Person person2("Alice", 25);
    person2.displayInfo();

    Person person3("Bob");
    person3.displayInfo();

    return 0;
}
