using System;
using System.Runtime.InteropServices;
using Cpp2ILInjected;
using Cpp2ILInjected.CallAnalysis;

namespace System
{
	[global::Cpp2ILInjected.Token(Token = "0x20001A2")]
	[StructLayout(2)]
	internal struct Variant
	{
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

		[global::Cpp2ILInjected.Token(Token = "0x4000892")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x0")]
		[global::System.Runtime.InteropServices.FieldOffset(0)]
		public short vt;

		[global::Cpp2ILInjected.Token(Token = "0x4000893")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x2")]
		[global::System.Runtime.InteropServices.FieldOffset(2)]
		public ushort wReserved1;

		[global::Cpp2ILInjected.Token(Token = "0x4000894")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x4")]
		[global::System.Runtime.InteropServices.FieldOffset(4)]
		public ushort wReserved2;

		[global::Cpp2ILInjected.Token(Token = "0x4000895")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x6")]
		[global::System.Runtime.InteropServices.FieldOffset(6)]
		public ushort wReserved3;

		[global::Cpp2ILInjected.Token(Token = "0x4000896")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x8")]
		[global::System.Runtime.InteropServices.FieldOffset(8)]
		public long llVal;

		[global::Cpp2ILInjected.Token(Token = "0x4000897")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x8")]
		[global::System.Runtime.InteropServices.FieldOffset(8)]
		public int lVal;

		[global::Cpp2ILInjected.Token(Token = "0x4000898")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x8")]
		[global::System.Runtime.InteropServices.FieldOffset(8)]
		public byte bVal;

		[global::Cpp2ILInjected.Token(Token = "0x4000899")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x8")]
		[global::System.Runtime.InteropServices.FieldOffset(8)]
		public short iVal;

		[global::Cpp2ILInjected.Token(Token = "0x400089A")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x8")]
		[global::System.Runtime.InteropServices.FieldOffset(8)]
		public float fltVal;

		[global::Cpp2ILInjected.Token(Token = "0x400089B")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x8")]
		[global::System.Runtime.InteropServices.FieldOffset(8)]
		public double dblVal;

		[global::Cpp2ILInjected.Token(Token = "0x400089C")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x8")]
		[global::System.Runtime.InteropServices.FieldOffset(8)]
		public short boolVal;

		[global::Cpp2ILInjected.Token(Token = "0x400089D")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x8")]
		[global::System.Runtime.InteropServices.FieldOffset(8)]
		public global::System.IntPtr bstrVal;

		[global::Cpp2ILInjected.Token(Token = "0x400089E")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x8")]
		[global::System.Runtime.InteropServices.FieldOffset(8)]
		public sbyte cVal;

		[global::Cpp2ILInjected.Token(Token = "0x400089F")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x8")]
		[global::System.Runtime.InteropServices.FieldOffset(8)]
		public ushort uiVal;

		[global::Cpp2ILInjected.Token(Token = "0x40008A0")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x8")]
		[global::System.Runtime.InteropServices.FieldOffset(8)]
		public uint ulVal;

		[global::Cpp2ILInjected.Token(Token = "0x40008A1")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x8")]
		[global::System.Runtime.InteropServices.FieldOffset(8)]
		public ulong ullVal;

		[global::Cpp2ILInjected.Token(Token = "0x40008A2")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x8")]
		[global::System.Runtime.InteropServices.FieldOffset(8)]
		public int intVal;

		[global::Cpp2ILInjected.Token(Token = "0x40008A3")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x8")]
		[global::System.Runtime.InteropServices.FieldOffset(8)]
		public uint uintVal;

		[global::Cpp2ILInjected.Token(Token = "0x40008A4")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x8")]
		[global::System.Runtime.InteropServices.FieldOffset(8)]
		public global::System.IntPtr pdispVal;

		[global::Cpp2ILInjected.Token(Token = "0x40008A5")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x8")]
		[global::System.Runtime.InteropServices.FieldOffset(8)]
		public global::System.BRECORD bRecord;
	}
}
