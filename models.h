# ifndef models
# define models

#include <string>
using namespace std;

struct Player {

    string name;
    string team;
    int position; // 1 thru 5;

};
struct Team {

    string name;
    Player players[5];


};
struct Game {

    string location;
    Team home;
    Team away;

};


# endif