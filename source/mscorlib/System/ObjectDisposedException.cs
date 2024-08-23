using System;
using System.Runtime.Serialization;
using Cpp2ILInjected;
using Cpp2ILInjected.CallAnalysis;

namespace System
{
	// Token: 0x020000B6 RID: 182
	[global::Cpp2ILInjected.Token(Token = "0x20000E8")]
	[global::System.Serializable]
	public class ObjectDisposedException : global::System.InvalidOperationException
	{
		// Token: 0x06000810 RID: 2064 RVA: 0x00015CA7 File Offset: 0x00013EA7
		[global::Cpp2ILInjected.Token(Token = "0x60008B8")]
		[global::Cpp2ILInjected.Address(RVA = "0x1C43BBC", Offset = "0x1C43BBC", Length = "0x60")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.InvalidOperationException), Member = ".ctor", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
		private ObjectDisposedException()
		{
			throw null;
		}

		// Token: 0x06000811 RID: 2065 RVA: 0x00015CAA File Offset: 0x00013EAA
		[global::Cpp2ILInjected.Token(Token = "0x60008B9")]
		[global::Cpp2ILInjected.Address(RVA = "0x1C43C54", Offset = "0x1C43C54", Length = "0x6C")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 136)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.InvalidOperationException), Member = ".ctor", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
		public ObjectDisposedException(string objectName)
		{
			throw null;
		}

		// Token: 0x06000812 RID: 2066 RVA: 0x00015CAD File Offset: 0x00013EAD
		[global::Cpp2ILInjected.Token(Token = "0x60008BA")]
		[global::Cpp2ILInjected.Address(RVA = "0x1C43C1C", Offset = "0x1C43C1C", Length = "0x38")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 33)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.InvalidOperationException), Member = ".ctor", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
		public ObjectDisposedException(string objectName, string message)
		{
			throw null;
		}

		// Token: 0x06000813 RID: 2067 RVA: 0x00015CB0 File Offset: 0x00013EB0
		[global::Cpp2ILInjected.Token(Token = "0x60008BB")]
		[global::Cpp2ILInjected.Address(RVA = "0x1C43CC0", Offset = "0x1C43CC0", Length = "0x88")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.InvalidOperationException), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(global::System.Runtime.Serialization.SerializationInfo),
			typeof(global::System.Runtime.Serialization.StreamingContext)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Runtime.Serialization.SerializationInfo), Member = "GetString", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
		protected ObjectDisposedException(global::System.Runtime.Serialization.SerializationInfo info, global::System.Runtime.Serialization.StreamingContext context)
		{
			throw null;
		}

		// Token: 0x06000814 RID: 2068 RVA: 0x00015CB3 File Offset: 0x00013EB3
		[global::Cpp2ILInjected.Token(Token = "0x60008BC")]
		[global::Cpp2ILInjected.Address(RVA = "0x1C43D48", Offset = "0x1C43D48", Length = "0x100")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Exception), Member = "GetObjectData", MemberParameters = new object[]
		{
			typeof(global::System.Runtime.Serialization.SerializationInfo),
			typeof(global::System.Runtime.Serialization.StreamingContext)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Type), Member = "GetTypeFromHandle", MemberParameters = new object[] { typeof(global::System.RuntimeTypeHandle) }, ReturnType = typeof(global::System.Type))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Runtime.Serialization.SerializationInfo), Member = "AddValue", MemberParameters = new object[]
		{
			typeof(string),
			typeof(object),
			typeof(global::System.Type)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 5)]
		public override void GetObjectData(global::System.Runtime.Serialization.SerializationInfo info, global::System.Runtime.Serialization.StreamingContext context)
		{
			throw null;
		}

		// Token: 0x1700007C RID: 124
		// (get) Token: 0x06000815 RID: 2069 RVA: 0x00015CB6 File Offset: 0x00013EB6
		[global::Cpp2ILInjected.Token(Token = "0x17000097")]
		public override string Message
		{
			[global::Cpp2ILInjected.Token(Token = "0x60008BD")]
			[global::Cpp2ILInjected.Address(RVA = "0x1C43F30", Offset = "0x1C43F30", Length = "0xD4")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::SR), Member = "Format", MemberParameters = new object[]
			{
				typeof(string),
				typeof(object)
			}, ReturnType = typeof(string))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Exception), Member = "get_Message", ReturnType = typeof(string))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Environment), Member = "get_NewLine", ReturnType = typeof(string))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(string), Member = "Concat", MemberParameters = new object[]
			{
				typeof(string),
				typeof(string),
				typeof(string)
			}, ReturnType = typeof(string))]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
			get
			{
				throw null;
			}
		}

		// Token: 0x1700007D RID: 125
		// (get) Token: 0x06000816 RID: 2070 RVA: 0x00015CB9 File Offset: 0x00013EB9
		[global::Cpp2ILInjected.Token(Token = "0x17000098")]
		public string ObjectName
		{
			[global::Cpp2ILInjected.Token(Token = "0x60008BE")]
			[global::Cpp2ILInjected.Address(RVA = "0x1C43E48", Offset = "0x1C43E48", Length = "0x54")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
			get
			{
				throw null;
			}
		}

		// Token: 0x0400022C RID: 556
		[global::Cpp2ILInjected.Token(Token = "0x400037E")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x90")]
		private string _objectName;
	}
}
