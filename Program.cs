int longestPalindrome(char* s) {
    int len = strlen(s);
    if(len <= 1) return len;
    int palLength[2001] = {0};
    int convert = 0;
    int retLen = 0;
    for(int x = 0; x < len; x++)
    {
        convert = s[x];
        palLength[convert]++;
//        printf("retLen = %d || %d\n",convert,palLength[convert]);
        if(palLength[convert] >= 2)
        {
            retLen = retLen + 2;
//            printf("Return = %d\n",retLen);
            palLength[convert] = 0;
        }

    }
    if(retLen < len)
    {
        retLen = retLen + 1;
    }
    return retLen;
}