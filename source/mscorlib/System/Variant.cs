using System;
using System.Runtime.InteropServices;
using Cpp2ILInjected;
using Cpp2ILInjected.CallAnalysis;

namespace System
{
	// Token: 0x02000156 RID: 342
	[global::Cpp2ILInjected.Token(Token = "0x20001A2")]
	[StructLayout(2)]
	internal struct Variant
	{
		// Token: 0x06000EFA RID: 3834 RVA: 0x00016F6A File Offset: 0x0001516A
		[global::Cpp2ILInjected.Token(Token = "0x6000FF8")]
		[global::Cpp2ILInjected.Address(RVA = "0x1C8BDB4", Offset = "0x1C8BDB4", Length = "0x74")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Runtime.InteropServices.Marshal), Member = "FreeBSTR", MemberParameters = new object[] { typeof(global::System.IntPtr) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
		public void Clear()
		{
			throw null;
		}

		// Token: 0x040006B7 RID: 1719
		[global::Cpp2ILInjected.Token(Token = "0x4000892")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x0")]
		[global::System.Runtime.InteropServices.FieldOffset(0)]
		public short vt;

		// Token: 0x040006B8 RID: 1720
		[global::Cpp2ILInjected.Token(Token = "0x4000893")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x2")]
		[global::System.Runtime.InteropServices.FieldOffset(2)]
		public ushort wReserved1;

		// Token: 0x040006B9 RID: 1721
		[global::Cpp2ILInjected.Token(Token = "0x4000894")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x4")]
		[global::System.Runtime.InteropServices.FieldOffset(4)]
		public ushort wReserved2;

		// Token: 0x040006BA RID: 1722
		[global::Cpp2ILInjected.Token(Token = "0x4000895")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x6")]
		[global::System.Runtime.InteropServices.FieldOffset(6)]
		public ushort wReserved3;

		// Token: 0x040006BB RID: 1723
		[global::Cpp2ILInjected.Token(Token = "0x4000896")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x8")]
		[global::System.Runtime.InteropServices.FieldOffset(8)]
		public long llVal;

		// Token: 0x040006BC RID: 1724
		[global::Cpp2ILInjected.Token(Token = "0x4000897")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x8")]
		[global::System.Runtime.InteropServices.FieldOffset(8)]
		public int lVal;

		// Token: 0x040006BD RID: 1725
		[global::Cpp2ILInjected.Token(Token = "0x4000898")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x8")]
		[global::System.Runtime.InteropServices.FieldOffset(8)]
		public byte bVal;

		// Token: 0x040006BE RID: 1726
		[global::Cpp2ILInjected.Token(Token = "0x4000899")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x8")]
		[global::System.Runtime.InteropServices.FieldOffset(8)]
		public short iVal;

		// Token: 0x040006BF RID: 1727
		[global::Cpp2ILInjected.Token(Token = "0x400089A")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x8")]
		[global::System.Runtime.InteropServices.FieldOffset(8)]
		public float fltVal;

		// Token: 0x040006C0 RID: 1728
		[global::Cpp2ILInjected.Token(Token = "0x400089B")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x8")]
		[global::System.Runtime.InteropServices.FieldOffset(8)]
		public double dblVal;

		// Token: 0x040006C1 RID: 1729
		[global::Cpp2ILInjected.Token(Token = "0x400089C")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x8")]
		[global::System.Runtime.InteropServices.FieldOffset(8)]
		public short boolVal;

		// Token: 0x040006C2 RID: 1730
		[global::Cpp2ILInjected.Token(Token = "0x400089D")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x8")]
		[global::System.Runtime.InteropServices.FieldOffset(8)]
		public global::System.IntPtr bstrVal;

		// Token: 0x040006C3 RID: 1731
		[global::Cpp2ILInjected.Token(Token = "0x400089E")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x8")]
		[global::System.Runtime.InteropServices.FieldOffset(8)]
		public sbyte cVal;

		// Token: 0x040006C4 RID: 1732
		[global::Cpp2ILInjected.Token(Token = "0x400089F")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x8")]
		[global::System.Runtime.InteropServices.FieldOffset(8)]
		public ushort uiVal;

		// Token: 0x040006C5 RID: 1733
		[global::Cpp2ILInjected.Token(Token = "0x40008A0")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x8")]
		[global::System.Runtime.InteropServices.FieldOffset(8)]
		public uint ulVal;

		// Token: 0x040006C6 RID: 1734
		[global::Cpp2ILInjected.Token(Token = "0x40008A1")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x8")]
		[global::System.Runtime.InteropServices.FieldOffset(8)]
		public ulong ullVal;

		// Token: 0x040006C7 RID: 1735
		[global::Cpp2ILInjected.Token(Token = "0x40008A2")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x8")]
		[global::System.Runtime.InteropServices.FieldOffset(8)]
		public int intVal;

		// Token: 0x040006C8 RID: 1736
		[global::Cpp2ILInjected.Token(Token = "0x40008A3")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x8")]
		[global::System.Runtime.InteropServices.FieldOffset(8)]
		public uint uintVal;

		// Token: 0x040006C9 RID: 1737
		[global::Cpp2ILInjected.Token(Token = "0x40008A4")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x8")]
		[global::System.Runtime.InteropServices.FieldOffset(8)]
		public global::System.IntPtr pdispVal;

		// Token: 0x040006CA RID: 1738
		[global::Cpp2ILInjected.Token(Token = "0x40008A5")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x8")]
		[global::System.Runtime.InteropServices.FieldOffset(8)]
		public global::System.BRECORD bRecord;
	}
}
