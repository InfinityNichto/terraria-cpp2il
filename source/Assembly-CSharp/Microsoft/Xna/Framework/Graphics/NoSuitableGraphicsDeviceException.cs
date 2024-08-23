using System;
using System.Runtime.Serialization;
using Cpp2ILInjected;
using Cpp2ILInjected.CallAnalysis;

namespace Microsoft.Xna.Framework.Graphics
{
	// Token: 0x020002B7 RID: 695
	[DataContract]
	[global::Cpp2ILInjected.Token(Token = "0x2000382")]
	public sealed class NoSuitableGraphicsDeviceException : Exception
	{
		// Token: 0x06001658 RID: 5720 RVA: 0x00025D72 File Offset: 0x00023F72
		[global::Cpp2ILInjected.Token(Token = "0x60017C8")]
		[global::Cpp2ILInjected.Address(RVA = "0xAB3A80", Offset = "0xAB3A80", Length = "0x58")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Exception), Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
		public NoSuitableGraphicsDeviceException()
		{
			throw null;
		}

		// Token: 0x06001659 RID: 5721 RVA: 0x00025D75 File Offset: 0x00023F75
		[global::Cpp2ILInjected.Token(Token = "0x60017C9")]
		[global::Cpp2ILInjected.Address(RVA = "0xAB2578", Offset = "0xAB2578", Length = "0x68")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(GraphicsDevice), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(GraphicsAdapter),
			typeof(GraphicsProfile),
			typeof(PresentationParameters)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Exception), Member = ".ctor", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
		public NoSuitableGraphicsDeviceException(string message)
		{
			throw null;
		}

		// Token: 0x0600165A RID: 5722 RVA: 0x00025D78 File Offset: 0x00023F78
		[global::Cpp2ILInjected.Token(Token = "0x60017CA")]
		[global::Cpp2ILInjected.Address(RVA = "0xAB3AD8", Offset = "0xAB3AD8", Length = "0x70")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Exception), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(string),
			typeof(Exception)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
		public NoSuitableGraphicsDeviceException(string message, Exception inner)
		{
			throw null;
		}
	}
}
