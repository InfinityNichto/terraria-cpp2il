using System;
using System.Resources;
using System.Runtime.Serialization;
using Cpp2ILInjected;
using Cpp2ILInjected.CallAnalysis;

namespace System.IO
{
	// Token: 0x0200046A RID: 1130
	[global::Cpp2ILInjected.Token(Token = "0x2000530")]
	[global::System.Serializable]
	public class EndOfStreamException : IOException
	{
		// Token: 0x0600248B RID: 9355 RVA: 0x0001AAAD File Offset: 0x00018CAD
		[global::Cpp2ILInjected.Token(Token = "0x600272F")]
		[global::Cpp2ILInjected.Address(RVA = "0x1B95A90", Offset = "0x1B95A90", Length = "0x5C")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "Terraria.Map.MapHelper.BitReader", Member = "Read", MemberParameters = new object[] { typeof(uint) }, ReturnType = typeof(uint))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.SystemException), Member = ".ctor", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
		public EndOfStreamException()
		{
			throw null;
		}

		// Token: 0x0600248C RID: 9356 RVA: 0x0001AAB0 File Offset: 0x00018CB0
		[global::Cpp2ILInjected.Token(Token = "0x6002730")]
		[global::Cpp2ILInjected.Address(RVA = "0x1B95AEC", Offset = "0x1B95AEC", Length = "0x24")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(global::System.Resources.ResourceReader), Member = "AllocateStringForNameIndex", MemberParameters = new object[]
		{
			typeof(int),
			typeof(ref int)
		}, ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(__Error), Member = "EndOfFile", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "Newtonsoft.Json.Bson.BsonReader", Member = "GetString", MemberParameters = new object[] { typeof(int) }, ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 3)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.SystemException), Member = ".ctor", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
		public EndOfStreamException(string message)
		{
			throw null;
		}

		// Token: 0x0600248D RID: 9357 RVA: 0x0001AAB3 File Offset: 0x00018CB3
		[global::Cpp2ILInjected.Token(Token = "0x6002731")]
		[global::Cpp2ILInjected.Address(RVA = "0x1B95B10", Offset = "0x1B95B10", Length = "0x8")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.SystemException), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(global::System.Runtime.Serialization.SerializationInfo),
			typeof(global::System.Runtime.Serialization.StreamingContext)
		}, ReturnType = typeof(void))]
		protected EndOfStreamException(global::System.Runtime.Serialization.SerializationInfo info, global::System.Runtime.Serialization.StreamingContext context)
		{
			throw null;
		}
	}
}
