using System;
using System.Runtime.CompilerServices;
using System.Runtime.Serialization;
using Cpp2ILInjected;
using Cpp2ILInjected.CallAnalysis;

namespace System.ComponentModel
{
	// Token: 0x020002C8 RID: 712
	[global::Cpp2ILInjected.Token(Token = "0x20003C7")]
	[Serializable]
	public class WarningException : SystemException
	{
		// Token: 0x0600174F RID: 5967 RVA: 0x00006FF5 File Offset: 0x000051F5
		[global::Cpp2ILInjected.Token(Token = "0x60019B1")]
		[global::Cpp2ILInjected.Address(RVA = "0x1E5FFDC", Offset = "0x1E5FFDC", Length = "0x20")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(SystemException), Member = ".ctor", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
		public WarningException()
		{
			throw null;
		}

		// Token: 0x06001750 RID: 5968 RVA: 0x00006FF8 File Offset: 0x000051F8
		[global::Cpp2ILInjected.Token(Token = "0x60019B2")]
		[global::Cpp2ILInjected.Address(RVA = "0x1E60028", Offset = "0x1E60028", Length = "0x1C")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(SystemException), Member = ".ctor", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
		public WarningException(string message)
		{
			throw null;
		}

		// Token: 0x06001751 RID: 5969 RVA: 0x00006FFB File Offset: 0x000051FB
		[global::Cpp2ILInjected.Token(Token = "0x60019B3")]
		[global::Cpp2ILInjected.Address(RVA = "0x1E60044", Offset = "0x1E60044", Length = "0x28")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(SystemException), Member = ".ctor", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
		public WarningException(string message, string helpUrl)
		{
			throw null;
		}

		// Token: 0x06001752 RID: 5970 RVA: 0x00006FFE File Offset: 0x000051FE
		[global::Cpp2ILInjected.Token(Token = "0x60019B4")]
		[global::Cpp2ILInjected.Address(RVA = "0x1E6006C", Offset = "0x1E6006C", Length = "0x8")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(SystemException), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(string),
			typeof(Exception)
		}, ReturnType = typeof(void))]
		public WarningException(string message, Exception innerException)
		{
			throw null;
		}

		// Token: 0x06001753 RID: 5971 RVA: 0x00007001 File Offset: 0x00005201
		[global::Cpp2ILInjected.Token(Token = "0x60019B5")]
		[global::Cpp2ILInjected.Address(RVA = "0x1E5FFFC", Offset = "0x1E5FFFC", Length = "0x2C")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(SystemException), Member = ".ctor", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
		public WarningException(string message, string helpUrl, string helpTopic)
		{
			throw null;
		}

		// Token: 0x06001754 RID: 5972 RVA: 0x00007004 File Offset: 0x00005204
		[global::Cpp2ILInjected.Token(Token = "0x60019B6")]
		[global::Cpp2ILInjected.Address(RVA = "0x1E60074", Offset = "0x1E60074", Length = "0x170")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(SystemException), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(SerializationInfo),
			typeof(StreamingContext)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Type), Member = "GetTypeFromHandle", MemberParameters = new object[] { typeof(RuntimeTypeHandle) }, ReturnType = typeof(Type))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(SerializationInfo), Member = "GetValue", MemberParameters = new object[]
		{
			typeof(string),
			typeof(Type)
		}, ReturnType = typeof(object))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 7)]
		protected WarningException(SerializationInfo info, StreamingContext context)
		{
			throw null;
		}

		// Token: 0x170005A6 RID: 1446
		// (get) Token: 0x06001755 RID: 5973 RVA: 0x00007007 File Offset: 0x00005207
		[global::Cpp2ILInjected.Token(Token = "0x170005DA")]
		public string HelpUrl
		{
			[CompilerGenerated]
			[global::Cpp2ILInjected.Token(Token = "0x60019B7")]
			[global::Cpp2ILInjected.Address(RVA = "0x1E601E4", Offset = "0x1E601E4", Length = "0x8")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			get
			{
				throw null;
			}
		}

		// Token: 0x170005A7 RID: 1447
		// (get) Token: 0x06001756 RID: 5974 RVA: 0x0000700A File Offset: 0x0000520A
		[global::Cpp2ILInjected.Token(Token = "0x170005DB")]
		public string HelpTopic
		{
			[CompilerGenerated]
			[global::Cpp2ILInjected.Token(Token = "0x60019B8")]
			[global::Cpp2ILInjected.Address(RVA = "0x1E601EC", Offset = "0x1E601EC", Length = "0x8")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			get
			{
				throw null;
			}
		}

		// Token: 0x06001757 RID: 5975 RVA: 0x0000700D File Offset: 0x0000520D
		[global::Cpp2ILInjected.Token(Token = "0x60019B9")]
		[global::Cpp2ILInjected.Address(RVA = "0x1E601F4", Offset = "0x1E601F4", Length = "0xAC")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Exception), Member = "GetObjectData", MemberParameters = new object[]
		{
			typeof(SerializationInfo),
			typeof(StreamingContext)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(SerializationInfo), Member = "AddValue", MemberParameters = new object[]
		{
			typeof(string),
			typeof(object)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
		public override void GetObjectData(SerializationInfo info, StreamingContext context)
		{
			throw null;
		}

		// Token: 0x04000EBC RID: 3772
		[CompilerGenerated]
		[global::Cpp2ILInjected.Token(Token = "0x40012DA")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x90")]
		private readonly string <HelpUrl>k__BackingField;

		// Token: 0x04000EBD RID: 3773
		[CompilerGenerated]
		[global::Cpp2ILInjected.Token(Token = "0x40012DB")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x98")]
		private readonly string <HelpTopic>k__BackingField;
	}
}
