using System;
using System.Runtime.InteropServices;
using Cpp2ILInjected;
using Cpp2ILInjected.CallAnalysis;

namespace System.Net.NetworkInformation.MacOsStructs
{
	[global::Cpp2ILInjected.Token(Token = "0x20002D0")]
	internal struct sockaddr_dl
	{
		[global::Cpp2ILInjected.Token(Token = "0x60012D8")]
		[global::Cpp2ILInjected.Address(RVA = "0x1E201DC", Offset = "0x1E201DC", Length = "0x188")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(MacOsNetworkInterfaceAPI), Member = "GetAllNetworkInterfaces", ReturnType = typeof(NetworkInterface[]))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Marshal), Member = "ReadByte", MemberParameters = new object[]
		{
			typeof(IntPtr),
			typeof(int)
		}, ReturnType = typeof(byte))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Marshal), Member = "ReadInt16", MemberParameters = new object[]
		{
			typeof(IntPtr),
			typeof(int)
		}, ReturnType = typeof(short))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Math), Member = "Max", MemberParameters = new object[]
		{
			typeof(int),
			typeof(int)
		}, ReturnType = typeof(int))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(IntPtr), Member = "ToInt64", ReturnType = typeof(long))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(IntPtr), Member = ".ctor", MemberParameters = new object[] { typeof(long) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Marshal), Member = "Copy", MemberParameters = new object[]
		{
			typeof(IntPtr),
			typeof(byte[]),
			typeof(int),
			typeof(int)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 6)]
		internal void Read(IntPtr ptr)
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x4000F2F")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x0")]
		public byte sdl_len;

		[global::Cpp2ILInjected.Token(Token = "0x4000F30")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x1")]
		public byte sdl_family;

		[global::Cpp2ILInjected.Token(Token = "0x4000F31")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x2")]
		public ushort sdl_index;

		[global::Cpp2ILInjected.Token(Token = "0x4000F32")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x4")]
		public byte sdl_type;

		[global::Cpp2ILInjected.Token(Token = "0x4000F33")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x5")]
		public byte sdl_nlen;

		[global::Cpp2ILInjected.Token(Token = "0x4000F34")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x6")]
		public byte sdl_alen;

		[global::Cpp2ILInjected.Token(Token = "0x4000F35")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x7")]
		public byte sdl_slen;

		[global::Cpp2ILInjected.Token(Token = "0x4000F36")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x8")]
		public byte[] sdl_data;
	}
}
