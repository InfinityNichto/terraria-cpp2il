using System;
using System.Runtime.Serialization;
using Cpp2ILInjected;
using Cpp2ILInjected.CallAnalysis;

namespace System.Globalization
{
	// Token: 0x020004A6 RID: 1190
	[global::Cpp2ILInjected.Token(Token = "0x2000584")]
	[global::System.Serializable]
	public class CultureNotFoundException : global::System.ArgumentException
	{
		// Token: 0x0600276F RID: 10095 RVA: 0x0001B2E7 File Offset: 0x000194E7
		[global::Cpp2ILInjected.Token(Token = "0x6002A9F")]
		[global::Cpp2ILInjected.Address(RVA = "0x1BD95B0", Offset = "0x1BD95B0", Length = "0x4C")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.ArgumentException), Member = ".ctor", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
		public CultureNotFoundException()
		{
			throw null;
		}

		// Token: 0x06002770 RID: 10096 RVA: 0x0001B2EA File Offset: 0x000194EA
		[global::Cpp2ILInjected.Token(Token = "0x6002AA0")]
		[global::Cpp2ILInjected.Address(RVA = "0x1BD963C", Offset = "0x1BD963C", Length = "0x14")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(CultureInfo), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(int),
			typeof(bool),
			typeof(bool)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(CultureInfo), Member = "CreateNotFoundException", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(global::System.Exception))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 2)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.ArgumentException), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(string),
			typeof(string)
		}, ReturnType = typeof(void))]
		public CultureNotFoundException(string paramName, string message)
		{
			throw null;
		}

		// Token: 0x06002771 RID: 10097 RVA: 0x0001B2ED File Offset: 0x000194ED
		[global::Cpp2ILInjected.Token(Token = "0x6002AA1")]
		[global::Cpp2ILInjected.Address(RVA = "0x1BD9650", Offset = "0x1BD9650", Length = "0x1BC")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
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
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 10)]
		protected CultureNotFoundException(global::System.Runtime.Serialization.SerializationInfo info, global::System.Runtime.Serialization.StreamingContext context)
		{
			throw null;
		}

		// Token: 0x06002772 RID: 10098 RVA: 0x0001B2F0 File Offset: 0x000194F0
		[global::Cpp2ILInjected.Token(Token = "0x6002AA2")]
		[global::Cpp2ILInjected.Address(RVA = "0x1BD980C", Offset = "0x1BD980C", Length = "0x164")]
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
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 8)]
		public override void GetObjectData(global::System.Runtime.Serialization.SerializationInfo info, global::System.Runtime.Serialization.StreamingContext context)
		{
			throw null;
		}

		// Token: 0x17000593 RID: 1427
		// (get) Token: 0x06002773 RID: 10099 RVA: 0x0001B2F3 File Offset: 0x000194F3
		[global::Cpp2ILInjected.Token(Token = "0x1700061B")]
		public virtual int? InvalidCultureId
		{
			[global::Cpp2ILInjected.Token(Token = "0x6002AA3")]
			[global::Cpp2ILInjected.Address(RVA = "0x1BD9970", Offset = "0x1BD9970", Length = "0x8")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			get
			{
				throw null;
			}
		}

		// Token: 0x17000594 RID: 1428
		// (get) Token: 0x06002774 RID: 10100 RVA: 0x0001B2F6 File Offset: 0x000194F6
		[global::Cpp2ILInjected.Token(Token = "0x1700061C")]
		public virtual string InvalidCultureName
		{
			[global::Cpp2ILInjected.Token(Token = "0x6002AA4")]
			[global::Cpp2ILInjected.Address(RVA = "0x1BD9978", Offset = "0x1BD9978", Length = "0x8")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			get
			{
				throw null;
			}
		}

		// Token: 0x17000595 RID: 1429
		// (get) Token: 0x06002775 RID: 10101 RVA: 0x0001B2F9 File Offset: 0x000194F9
		[global::Cpp2ILInjected.Token(Token = "0x1700061D")]
		private static string DefaultMessage
		{
			[global::Cpp2ILInjected.Token(Token = "0x6002AA5")]
			[global::Cpp2ILInjected.Address(RVA = "0x1BD95FC", Offset = "0x1BD95FC", Length = "0x40")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
			get
			{
				throw null;
			}
		}

		// Token: 0x17000596 RID: 1430
		// (get) Token: 0x06002776 RID: 10102 RVA: 0x0001B2FC File Offset: 0x000194FC
		[global::Cpp2ILInjected.Token(Token = "0x1700061E")]
		private string FormatedInvalidCultureId
		{
			[global::Cpp2ILInjected.Token(Token = "0x6002AA6")]
			[global::Cpp2ILInjected.Address(RVA = "0x1BD9980", Offset = "0x1BD9980", Length = "0x134")]
			[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(CultureNotFoundException), Member = "get_Message", ReturnType = typeof(string))]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(CultureInfo), Member = "get_InvariantCulture", ReturnType = typeof(CultureInfo))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(int?), Member = "get_Value", ReturnType = "T")]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(string), Member = "Format", MemberParameters = new object[]
			{
				typeof(global::System.IFormatProvider),
				typeof(string),
				typeof(object)
			}, ReturnType = typeof(string))]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 7)]
			get
			{
				throw null;
			}
		}

		// Token: 0x17000597 RID: 1431
		// (get) Token: 0x06002777 RID: 10103 RVA: 0x0001B2FF File Offset: 0x000194FF
		[global::Cpp2ILInjected.Token(Token = "0x1700061F")]
		public override string Message
		{
			[global::Cpp2ILInjected.Token(Token = "0x6002AA7")]
			[global::Cpp2ILInjected.Address(RVA = "0x1BD9AB4", Offset = "0x1BD9AB4", Length = "0xBC")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.ArgumentException), Member = "get_Message", ReturnType = typeof(string))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(CultureNotFoundException), Member = "get_FormatedInvalidCultureId", ReturnType = typeof(string))]
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
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
			get
			{
				throw null;
			}
		}

		// Token: 0x04001372 RID: 4978
		[global::Cpp2ILInjected.Token(Token = "0x40016CD")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x98")]
		private string _invalidCultureName;

		// Token: 0x04001373 RID: 4979
		[global::Cpp2ILInjected.Token(Token = "0x40016CE")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0xA0")]
		private int? _invalidCultureId;
	}
}
