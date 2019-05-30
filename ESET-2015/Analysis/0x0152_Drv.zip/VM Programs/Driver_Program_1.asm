/*
   This is the initialize routine. 
   Basing on the information contained in the header:
   This will actually run.
   
	0: Signature: 0x3713
	2: Size: 0x2b5
	6: Main: 0x12 (0x04)
	A: AdditionalData: 0x131 (0x123)
*/
	equal Key, byte 0x0
	cjmp dword KeyNull

	equal KeyLenght, byte 0x0
	cjmp dword Exit

	mov dword CurrentKeyPtr, dword Key
	mov dword Buffer1Ptr, dword 0x164 + offset ; Buffer_1
	mov dword Key2Ptr, dword 0x137 + offset ; Key2
	mov dword KeyEnd, dword CurrentKeyPtr
	add KeyEnd, dword KeyLenght
	mov dword Buffer1End, dword Buffer1Ptr
	mov dword reg_0, dword 0x160 + offset 
	add Buffer1End, dword [reg_0]			 ; Buffer_1 lenght (0x12)
	mov dword Key2EndPtr, dword Key2Ptr
	add Key2EndPtr, byte 0x4				; Key2 Lenght

Loop1: 
		notequal CurrentKeyPtr, dword KeyEnd
		cjmp dword Skip1
		mov dword CurrentKeyPtr, dword Key
	Skip1:
		notequal Key2Ptr, dword Key2EndPtr
		cjmp dword Skip2
		mov dword Key2Ptr, dword 0x137 + offset
	Skip2:
		equal Buffer1Ptr, dword Buffer1End
		cjmp dword Load2nd
		mov byte reg_0, byte [CurrentKeyPtr]
		xor reg_0, byte [Buffer1Ptr]
		add reg_0, byte 0x1
		ror reg_0, byte 0x1
		xor reg_0, byte [Key2Ptr]
		mov byte [Buffer1Ptr], byte reg_0
		add CurrentKeyPtr, byte 0x1
		add Buffer1Ptr, byte 0x1
		add Key2Ptr, byte 0x1
		jmp dword Loop1


KeyNull:
	mov dword Buffer1Ptr, dword 0x140 + offset
	mov dword Key2Ptr, dword 0x137 + offset
	mov dword Buffer1End, dword Buffer1Ptr
	mov dword reg_0, dword 0x13C + offset
	add Buffer1End, dword [reg_0]
	mov dword Key2EndPtr, dword Key2Ptr
	add Key2EndPtr, byte 0x4

Loop2:
		notequal Key2Ptr, dword Key2EndPtr
		cjmp dword Skip3
		mov dword Key2Ptr, dword 0x137 + offset
	Skip3: 
		equal Buffer1Ptr, dword Buffer1End
		cjmp dword Load1st
		mov byte reg_0, byte 0x0
		xor reg_0, byte [Buffer1Ptr]
		add reg_0, byte 0x1
		ror reg_0, byte 0x1
		xor reg_0, byte [Key2Ptr]
		mov byte [Buffer1Ptr], byte reg_0
		add Buffer1Ptr, byte 0x1
		add Key2Ptr, byte 0x1
		jmp dword Loop2

Load1st:
	mov dword reg_0, dword 0x13C + offset
	mov dword reg_0, dword [reg_0]
	push dword reg_0
	push dword 0x140 + offset
	jmp dword LoadVM

Load2nd:
	mov dword reg_0, dword 0x160 + offset
	mov dword reg_0, dword [reg_0]
	push dword reg_0
	push dword 0x164 + offset

LoadVM:
	push dword BlockSize
	push dword CurrentOffset
	reloadvm dword 0x0 + offset, byte 0x4

Exit:
	exit
