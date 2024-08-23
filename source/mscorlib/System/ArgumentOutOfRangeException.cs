using System;
using System.Runtime.Serialization;
using Cpp2ILInjected;
using Cpp2ILInjected.CallAnalysis;

namespace System
{
	// Token: 0x02000060 RID: 96
	[global::Cpp2ILInjected.Token(Token = "0x2000085")]
	[global::System.Serializable]
	public class ArgumentOutOfRangeException : global::System.ArgumentException
	{
		// Token: 0x06000341 RID: 833 RVA: 0x00014EF4 File Offset: 0x000130F4
		[global::Cpp2ILInjected.Token(Token = "0x60003D2")]
		[global::Cpp2ILInjected.Address(RVA = "0x1BB5E94", Offset = "0x1BB5E94", Length = "0x5C")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 24)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.SystemException), Member = ".ctor", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
		public ArgumentOutOfRangeException()
		{
			throw null;
		}

		// Token: 0x06000342 RID: 834 RVA: 0x00014EF7 File Offset: 0x000130F7
		[global::Cpp2ILInjected.Token(Token = "0x60003D3")]
		[global::Cpp2ILInjected.Address(RVA = "0x1BB5EF0", Offset = "0x1BB5EF0", Length = "0x6C")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 203)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.SystemException), Member = ".ctor", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
		public ArgumentOutOfRangeException(string paramName)
		{
			throw null;
		}

		// Token: 0x06000343 RID: 835 RVA: 0x00014EFA File Offset: 0x000130FA
		[global::Cpp2ILInjected.Token(Token = "0x60003D4")]
		[global::Cpp2ILInjected.Address(RVA = "0x1BB1C48", Offset = "0x1BB1C48", Length = "0x38")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 502)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.SystemException), Member = ".ctor", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
		public ArgumentOutOfRangeException(string paramName, string message)
		{
			throw null;
		}

		// Token: 0x06000344 RID: 836 RVA: 0x00014EFD File Offset: 0x000130FD
		[global::Cpp2ILInjected.Token(Token = "0x60003D5")]
		[global::Cpp2ILInjected.Address(RVA = "0x1BB2CE0", Offset = "0x1BB2CE0", Length = "0x3C")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 42)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.SystemException), Member = ".ctor", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
		public ArgumentOutOfRangeException(string paramName, object actualValue, string message)
		{
			throw null;
		}

		// Token: 0x06000345 RID: 837 RVA: 0x00014F00 File Offset: 0x00013100
		[global::Cpp2ILInjected.Token(Token = "0x60003D6")]
		[global::Cpp2ILInjected.Address(RVA = "0x1BB5F5C", Offset = "0x1BB5F5C", Length = "0xD0")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.ArgumentException), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(global::System.Runtime.Serialization.SerializationInfo),
			typeof(global::System.Runtime.Serialization.StreamingContext)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Type), Member = "GetTypeFromHandle", MemberParameters = new object[] { typeof(global::System.RuntimeTypeHandle) }, ReturnType = typeof(global::System.Type))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Runtime.Serialization.SerializationInfo), Member = "GetValue", MemberParameters = new object[]
		{
			typeof(string),
			typeof(global::System.Type)
		}, ReturnType = typeof(object))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 4)]
		protected ArgumentOutOfRangeException(global::System.Runtime.Serialization.SerializationInfo info, global::System.Runtime.Serialization.StreamingContext context)
		{
			throw null;
		}

		// Token: 0x06000346 RID: 838 RVA: 0x00014F03 File Offset: 0x00013103
		[global::Cpp2ILInjected.Token(Token = "0x60003D7")]
		[global::Cpp2ILInjected.Address(RVA = "0x1BB602C", Offset = "0x1BB602C", Length = "0xD0")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.ArgumentException), Member = "GetObjectData", MemberParameters = new object[]
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
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 4)]
		public override void GetObjectData(global::System.Runtime.Serialization.SerializationInfo info, global::System.Runtime.Serialization.StreamingContext context)
		{
			throw null;
		}

		// Token: 0x17000042 RID: 66
		// (get) Token: 0x06000347 RID: 839 RVA: 0x00014F06 File Offset: 0x00013106
		[global::Cpp2ILInjected.Token(Token = "0x17000059")]
		public override string Message
		{
			[global::Cpp2ILInjected.Token(Token = "0x60003D8")]
			[global::Cpp2ILInjected.Address(RVA = "0x1BB60FC", Offset = "0x1BB60FC", Length = "0xAC")]
			[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.ArgumentException), Member = "get_Message", ReturnType = typeof(string))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::SR), Member = "Format", MemberParameters = new object[]
			{
				typeof(string),
				typeof(object)
			}, ReturnType = typeof(string))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Environment), Member = "get_NewLine", ReturnType = typeof(string))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(string), Member = "Concat", MemberParameters = new object[]
			{
				typeof(string),
				typeof(string),
				typeof(string)
			}, ReturnType = typeof(string))]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
			get
			{
				throw null;
			}
		}

		// Token: 0x040000FB RID: 251
		[global::Cpp2ILInjected.Token(Token = "0x40001DC")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x98")]
		private object _actualValue;
	}
}
