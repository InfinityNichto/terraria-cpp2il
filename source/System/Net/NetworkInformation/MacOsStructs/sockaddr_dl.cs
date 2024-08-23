using System;
using System.Runtime.InteropServices;
using Cpp2ILInjected;
using Cpp2ILInjected.CallAnalysis;

namespace System.Net.NetworkInformation.MacOsStructs
{
	// Token: 0x020001EE RID: 494
	[global::Cpp2ILInjected.Token(Token = "0x20002D0")]
	internal struct sockaddr_dl
	{
		// Token: 0x060010DF RID: 4319 RVA: 0x00005E94 File Offset: 0x00004094
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

		// Token: 0x04000B5E RID: 2910
		[global::Cpp2ILInjected.Token(Token = "0x4000F2F")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x0")]
		public byte sdl_len;

		// Token: 0x04000B5F RID: 2911
		[global::Cpp2ILInjected.Token(Token = "0x4000F30")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x1")]
		public byte sdl_family;

		// Token: 0x04000B60 RID: 2912
		[global::Cpp2ILInjected.Token(Token = "0x4000F31")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x2")]
		public ushort sdl_index;

		// Token: 0x04000B61 RID: 2913
		[global::Cpp2ILInjected.Token(Token = "0x4000F32")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x4")]
		public byte sdl_type;

		// Token: 0x04000B62 RID: 2914
		[global::Cpp2ILInjected.Token(Token = "0x4000F33")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x5")]
		public byte sdl_nlen;

		// Token: 0x04000B63 RID: 2915
		[global::Cpp2ILInjected.Token(Token = "0x4000F34")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x6")]
		public byte sdl_alen;

		// Token: 0x04000B64 RID: 2916
		[global::Cpp2ILInjected.Token(Token = "0x4000F35")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x7")]
		public byte sdl_slen;

		// Token: 0x04000B65 RID: 2917
		[global::Cpp2ILInjected.Token(Token = "0x4000F36")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x8")]
		public byte[] sdl_data;
	}
}
