using System;
using System.Runtime.Serialization;
using Cpp2ILInjected;
using Cpp2ILInjected.CallAnalysis;

namespace System.Net
{
	// Token: 0x02000176 RID: 374
	[global::Cpp2ILInjected.Token(Token = "0x2000219")]
	[Serializable]
	public class CookieException : FormatException, ISerializable
	{
		// Token: 0x06000BF5 RID: 3061 RVA: 0x0000503F File Offset: 0x0000323F
		[global::Cpp2ILInjected.Token(Token = "0x6000D53")]
		[global::Cpp2ILInjected.Address(RVA = "0x1F35E3C", Offset = "0x1F35E3C", Length = "0x8")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(FormatException), Member = ".ctor", ReturnType = typeof(void))]
		public CookieException()
		{
			throw null;
		}

		// Token: 0x06000BF6 RID: 3062 RVA: 0x00005042 File Offset: 0x00003242
		[global::Cpp2ILInjected.Token(Token = "0x6000D54")]
		[global::Cpp2ILInjected.Address(RVA = "0x1F2C748", Offset = "0x1F2C748", Length = "0x8")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Cookie), Member = "set_Name", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Cookie), Member = "VerifySetDefaults", MemberParameters = new object[]
		{
			typeof(CookieVariant),
			typeof(Uri),
			typeof(bool),
			typeof(string),
			typeof(bool),
			typeof(bool)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Cookie), Member = "set_Port", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(CookieContainer), Member = "Add", MemberParameters = new object[] { typeof(Cookie) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(CookieContainer), Member = "Add", MemberParameters = new object[]
		{
			typeof(Cookie),
			typeof(bool)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 5)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(FormatException), Member = ".ctor", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
		internal CookieException(string message)
		{
			throw null;
		}

		// Token: 0x06000BF7 RID: 3063 RVA: 0x00005045 File Offset: 0x00003245
		[global::Cpp2ILInjected.Token(Token = "0x6000D55")]
		[global::Cpp2ILInjected.Address(RVA = "0x1F3386C", Offset = "0x1F3386C", Length = "0x8")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(CookieContainer), Member = "Add", MemberParameters = new object[]
		{
			typeof(Cookie),
			typeof(bool)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(CookieContainer), Member = "CookieCutter", MemberParameters = new object[]
		{
			typeof(Uri),
			typeof(string),
			typeof(string),
			typeof(bool)
		}, ReturnType = typeof(CookieCollection))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 2)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(FormatException), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(string),
			typeof(Exception)
		}, ReturnType = typeof(void))]
		internal CookieException(string message, Exception inner)
		{
			throw null;
		}

		// Token: 0x06000BF8 RID: 3064 RVA: 0x00005048 File Offset: 0x00003248
		[global::Cpp2ILInjected.Token(Token = "0x6000D56")]
		[global::Cpp2ILInjected.Address(RVA = "0x1F35E44", Offset = "0x1F35E44", Length = "0x8")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(FormatException), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(SerializationInfo),
			typeof(StreamingContext)
		}, ReturnType = typeof(void))]
		protected CookieException(SerializationInfo serializationInfo, StreamingContext streamingContext)
		{
			throw null;
		}

		// Token: 0x06000BF9 RID: 3065 RVA: 0x0000504B File Offset: 0x0000324B
		[global::Cpp2ILInjected.Token(Token = "0x6000D57")]
		[global::Cpp2ILInjected.Address(RVA = "0x1F35E4C", Offset = "0x1F35E4C", Length = "0x8")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Exception), Member = "GetObjectData", MemberParameters = new object[]
		{
			typeof(SerializationInfo),
			typeof(StreamingContext)
		}, ReturnType = typeof(void))]
		private void System.Runtime.Serialization.ISerializable.GetObjectData(SerializationInfo serializationInfo, StreamingContext streamingContext)
		{
			throw null;
		}

		// Token: 0x06000BFA RID: 3066 RVA: 0x0000504E File Offset: 0x0000324E
		[global::Cpp2ILInjected.Token(Token = "0x6000D58")]
		[global::Cpp2ILInjected.Address(RVA = "0x1F35E54", Offset = "0x1F35E54", Length = "0x8")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Exception), Member = "GetObjectData", MemberParameters = new object[]
		{
			typeof(SerializationInfo),
			typeof(StreamingContext)
		}, ReturnType = typeof(void))]
		public override void GetObjectData(SerializationInfo serializationInfo, StreamingContext streamingContext)
		{
			throw null;
		}
	}
}
