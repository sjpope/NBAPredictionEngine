#include <iostream>
#include <bits/stdc++.h>
#include <models.h>
using namespace std;

int main(){

    cout << "Hi!";

    // Establish Interface for user to choose team(s) 

    // Set each thread to pull latest team / player stats.
    // Hardcoded to Mavs / Timberwolves Game

    // Assess Pts/Reb/Ast, FG%, Mins.
    Team mavs, wolves;
    mavs.name = "Dallas Mavericks";
    wolves.name = "Minnesota Timberwolves";

    printf("Simulating Match: %d vs %d", mavs.name, wolves.name);


    cout << "Done!";
    
    return 0;
}