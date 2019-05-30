/*
    This is the main routine.
*/
vm_0000: allocate word 0x100
vm_0004: mov dword Buffer100, dword Index1
vm_0007: mov byte Index2, byte 0x0

; Init buffer with increasing number from 0 to 0xFF
loop0:
vm_000B: mov byte [Index1], byte Index2
vm_000E: add Index1, byte 0x1
vm_0012: add Index2, byte 0x1
vm_0016: less Index2, word 0x100
vm_001B: cjmp dword loop0

vm_0021: mov byte Index1, byte 0x0
vm_0025: mov byte Index2, byte 0x0
vm_0029: mov dword CurrentBuffer1, dword Buffer1Begin
vm_002C: mov dword Buffer1End, dword CurrentBuffer1
vm_002F: add Buffer1End, dword Buffer1Size

loop1:
	vm_0032: notequal CurrentBuffer1, dword Buffer1End
	vm_0035: cjmp dword 0x3E
	vm_003B: mov dword CurrentBuffer1, dword Buffer1Begin

	vm_003E: mov dword reg_3, dword Buffer100
	vm_0041: add reg_3, dword Index1
	
	vm_0044: add Index2, byte [reg_3]
	vm_0047: add Index2, byte [CurrentBuffer1]
	vm_004A: mod Index2, word 0x100
	
	vm_004F: mov dword reg_3, dword Buffer100
	vm_0052: add reg_3, dword Index1
	
	vm_0055: mov dword reg_15, dword Buffer100
	vm_0058: add reg_15, dword Index2
	vm_005B: mov byte reg_2, byte [reg_3]
	vm_005E: mov byte [reg_3], byte [reg_15]
	vm_0061: mov byte [reg_15], byte reg_2
	
	vm_0064: add Index1, byte 0x1	
	vm_0068: add CurrentBuffer1, byte 0x1
	vm_006C: less Index1, word 0x100
	vm_0071: cjmp dword loop1
	
vm_0077: mov byte Index1, byte 0x0
vm_007B: mov byte Index2, byte 0x0
vm_007F: mov dword reg_3, dword CurrentBlock
vm_0082: mov dword CurrentBuffer1, dword reg_3
vm_0085: add CurrentBuffer1, dword BlockSize

loop2:
	vm_0088: equal reg_3, dword CurrentBuffer1
	vm_008B: cjmp dword Exit
	vm_0091: add Index1, byte 0x1
	vm_0095: mod Index1, word 0x100
	vm_009A: mov dword reg_2, dword Buffer100
	vm_009D: add reg_2, dword Index1
	vm_00A0: add Index2, byte [reg_2]
	vm_00A3: mod Index2, word 0x100
	vm_00A8: mov dword Buffer1End, dword Buffer100
	vm_00AB: add Buffer1End, dword Index2
	vm_00AE: mov byte reg_15, byte [reg_2]
	vm_00B1: mov byte [reg_2], byte [Buffer1End]
	vm_00B4: mov byte [Buffer1End], byte reg_15
	vm_00B7: mov byte reg_15, byte 0x0
	vm_00BB: add reg_15, byte [reg_2]
	vm_00BE: add reg_15, byte [Buffer1End]
	vm_00C1: mod reg_15, word 0x100
	vm_00C6: add reg_15, dword Buffer100
	vm_00C9: mov byte reg_15, byte [reg_15]
	vm_00CC: xor reg_15, byte [reg_3]
	vm_00CF: mov byte [reg_3], byte reg_15
	vm_00D2: add reg_3, byte 0x1
	vm_00D6: jmp dword loop2
	
Exit:
vm_00DC: deallocate dword Buffer100
vm_00DE: exit