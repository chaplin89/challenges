for (int i=0; i<0x100; i++)
	Buffer100[i] =  i;

for (int i = 0; i<0x100; i++)
{
	j+=(Buffer100[i] + Buffer1[i % Buffer1Size]) % 0x100;
	
	int temp = Buffer100[i];
	Buffer100[i] = Buffer100[j];
	Buffer100[j] = temp;
}

for (BYTE* ptr = BlockBegin; ptr!=BlockEnd; ptr++)
{
	i = (i + 1) % 0x100;
	j += Buffer100[i] % 0x100;
	
	int temp = Buffer100[i];
	Buffer100[i] = buffer100[j];
	Buffer100[j] = temp;
	
	temp = (Buffer100[i] + Buffer100[j]) % 0x100;
	*ptr = Buffer100[temp] ^ ptr;
}