using System;
using System.Runtime.InteropServices;
using Cpp2ILInjected;
using Cpp2ILInjected.CallAnalysis;

namespace System.Net.NetworkInformation.AixStructs
{
	// Token: 0x020001F7 RID: 503
	[global::Cpp2ILInjected.Token(Token = "0x20002DC")]
	internal struct sockaddr_dl
	{
		// Token: 0x060010E0 RID: 4320 RVA: 0x00005E97 File Offset: 0x00004097
		[global::Cpp2ILInjected.Token(Token = "0x60012D9")]
		[global::Cpp2ILInjected.Address(RVA = "0x1E1E0B8", Offset = "0x1E1E0B8", Length = "0x188")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(AixNetworkInterfaceAPI), Member = "GetAllNetworkInterfaces", ReturnType = typeof(NetworkInterface[]))]
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

		// Token: 0x04000B7B RID: 2939
		[global::Cpp2ILInjected.Token(Token = "0x4000F4F")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x0")]
		public byte sdl_len;

		// Token: 0x04000B7C RID: 2940
		[global::Cpp2ILInjected.Token(Token = "0x4000F50")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x1")]
		public byte sdl_family;

		// Token: 0x04000B7D RID: 2941
		[global::Cpp2ILInjected.Token(Token = "0x4000F51")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x2")]
		public ushort sdl_index;

		// Token: 0x04000B7E RID: 2942
		[global::Cpp2ILInjected.Token(Token = "0x4000F52")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x4")]
		public byte sdl_type;

		// Token: 0x04000B7F RID: 2943
		[global::Cpp2ILInjected.Token(Token = "0x4000F53")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x5")]
		public byte sdl_nlen;

		// Token: 0x04000B80 RID: 2944
		[global::Cpp2ILInjected.Token(Token = "0x4000F54")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x6")]
		public byte sdl_alen;

		// Token: 0x04000B81 RID: 2945
		[global::Cpp2ILInjected.Token(Token = "0x4000F55")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x7")]
		public byte sdl_slen;

		// Token: 0x04000B82 RID: 2946
		[global::Cpp2ILInjected.Token(Token = "0x4000F56")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x8")]
		public byte[] sdl_data;
	}
}
