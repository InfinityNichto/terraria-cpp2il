using System;
using System.Runtime.Serialization;
using Cpp2ILInjected;
using Cpp2ILInjected.CallAnalysis;

namespace System.ComponentModel
{
	// Token: 0x020002E5 RID: 741
	[global::Cpp2ILInjected.Token(Token = "0x20003E5")]
	[Serializable]
	public class LicenseException : SystemException
	{
		// Token: 0x060017EA RID: 6122 RVA: 0x00007160 File Offset: 0x00005360
		[global::Cpp2ILInjected.Token(Token = "0x6001A53")]
		[global::Cpp2ILInjected.Address(RVA = "0x1E670E4", Offset = "0x1E670E4", Length = "0xE0")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(LicenseManager), Member = "Validate", MemberParameters = new object[] { typeof(Type) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = "SR", Member = "GetString", MemberParameters = new object[]
		{
			typeof(string),
			typeof(object[])
		}, ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(SystemException), Member = ".ctor", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 6)]
		public LicenseException(Type type)
		{
			throw null;
		}

		// Token: 0x060017EB RID: 6123 RVA: 0x00007163 File Offset: 0x00005363
		[global::Cpp2ILInjected.Token(Token = "0x6001A54")]
		[global::Cpp2ILInjected.Address(RVA = "0x1E67200", Offset = "0x1E67200", Length = "0x120")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(LicenseManager), Member = "Validate", MemberParameters = new object[]
		{
			typeof(Type),
			typeof(object)
		}, ReturnType = typeof(License))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = "GetType", ReturnType = typeof(Type))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = "SR", Member = "GetString", MemberParameters = new object[]
		{
			typeof(string),
			typeof(object[])
		}, ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(SystemException), Member = ".ctor", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 7)]
		public LicenseException(Type type, object instance)
		{
			throw null;
		}

		// Token: 0x060017EC RID: 6124 RVA: 0x00007166 File Offset: 0x00005366
		[global::Cpp2ILInjected.Token(Token = "0x6001A55")]
		[global::Cpp2ILInjected.Address(RVA = "0x1E671C4", Offset = "0x1E671C4", Length = "0x3C")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(SystemException), Member = ".ctor", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
		public LicenseException(Type type, object instance, string message)
		{
			throw null;
		}

		// Token: 0x060017ED RID: 6125 RVA: 0x00007169 File Offset: 0x00005369
		[global::Cpp2ILInjected.Token(Token = "0x6001A56")]
		[global::Cpp2ILInjected.Address(RVA = "0x1E67320", Offset = "0x1E67320", Length = "0x40")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(SystemException), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(string),
			typeof(Exception)
		}, ReturnType = typeof(void))]
		public LicenseException(Type type, object instance, string message, Exception innerException)
		{
			throw null;
		}

		// Token: 0x060017EE RID: 6126 RVA: 0x0000716C File Offset: 0x0000536C
		[global::Cpp2ILInjected.Token(Token = "0x6001A57")]
		[global::Cpp2ILInjected.Address(RVA = "0x1E67360", Offset = "0x1E67360", Length = "0x178")]
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
		protected LicenseException(SerializationInfo info, StreamingContext context)
		{
			throw null;
		}

		// Token: 0x170005D3 RID: 1491
		// (get) Token: 0x060017EF RID: 6127 RVA: 0x0000716F File Offset: 0x0000536F
		[global::Cpp2ILInjected.Token(Token = "0x1700060B")]
		public Type LicensedType
		{
			[global::Cpp2ILInjected.Token(Token = "0x6001A58")]
			[global::Cpp2ILInjected.Address(RVA = "0x1E674D8", Offset = "0x1E674D8", Length = "0x8")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			get
			{
				throw null;
			}
		}

		// Token: 0x060017F0 RID: 6128 RVA: 0x00007172 File Offset: 0x00005372
		[global::Cpp2ILInjected.Token(Token = "0x6001A59")]
		[global::Cpp2ILInjected.Address(RVA = "0x1E674E0", Offset = "0x1E674E0", Length = "0xF0")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(SerializationInfo), Member = "AddValue", MemberParameters = new object[]
		{
			typeof(string),
			typeof(object)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Exception), Member = "GetObjectData", MemberParameters = new object[]
		{
			typeof(SerializationInfo),
			typeof(StreamingContext)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ArgumentNullException), Member = ".ctor", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 7)]
		public override void GetObjectData(SerializationInfo info, StreamingContext context)
		{
			throw null;
		}

		// Token: 0x04000EEA RID: 3818
		[global::Cpp2ILInjected.Token(Token = "0x400130B")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x90")]
		private Type type;

		// Token: 0x04000EEB RID: 3819
		[global::Cpp2ILInjected.Token(Token = "0x400130C")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x98")]
		private object instance;
	}
}
