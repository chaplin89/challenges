/*
   This is the initialize routine. 
   Basing on the information contained in the header:
   This will actually run.
   
	0: Signature: 0x481c
	2: Size: 0x137
	6: Main: 0x58 (0x4A)
	A: AdditionalData: 0x137 (0x11F)
*/
mov dword reg_0, dword program
mov byte reg_1, byte [reg_0]
add reg_0, byte 0x1
mov byte reg_2, byte [reg_0]
add reg_0, byte 0x5
mov dword reg_3, dword [reg_0]
mov dword reg_0, dword size
add reg_0, dword program
add reg_3, dword program

loop1:
	mov byte reg_4, byte [reg_3]
	xor reg_4, dword reg_1
	add reg_1, dword reg_2
	mov byte [reg_3], byte reg_4
	add reg_3, byte 0x1
	less reg_3, dword reg_0
	cjmp dword loop1

mov dword reg_0, dword program
mov byte [reg_0], byte 0x37
add reg_0, byte 0x1
mov byte [reg_0], byte 0x13
exit