#include <iostream>
#include <fstream>
#include <string>
#include <cstdlib>
#include <time.h>

using namespace std;

class NumberGenerator{

	public:
		
        NumberGenrierator(string path); //constructor
        int deleteArchive(string path);
        int deleteArquive();
	
    private:
        
        long long int qdtNumeros;
        long long int range;
        string path;
        
        int create();
};

#endif