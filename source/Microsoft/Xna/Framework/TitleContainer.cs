using System;
using System.IO;
using System.Text;
using Cpp2ILInjected;
using Cpp2ILInjected.CallAnalysis;
using ReLogic.Content.Sources;
using UnityEngine;

namespace Microsoft.Xna.Framework
{
	// Token: 0x0200026E RID: 622
	[global::Cpp2ILInjected.Token(Token = "0x200032F")]
	public class TitleContainer
	{
		// Token: 0x06001222 RID: 4642 RVA: 0x00025133 File Offset: 0x00023333
		[global::Cpp2ILInjected.Token(Token = "0x600137F")]
		[global::Cpp2ILInjected.Address(RVA = "0xA8FD20", Offset = "0xA8FD20", Length = "0x1C4")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(XnaContentSource), Member = "OpenStream", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(Stream))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Path), Member = "GetDirectoryName", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Path), Member = "GetFileNameWithoutExtension", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Path), Member = "Combine", MemberParameters = new object[]
		{
			typeof(string),
			typeof(string)
		}, ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(string), Member = "Replace", MemberParameters = new object[]
		{
			typeof(string),
			typeof(string)
		}, ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Resources), Member = "Load", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(global::UnityEngine.Object))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(MemoryStream), Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(UTF8Encoding), Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(TextAsset), Member = "get_text", ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 10)]
		internal static Stream OpenStream(string path)
		{
			throw null;
		}

		// Token: 0x06001223 RID: 4643 RVA: 0x00025136 File Offset: 0x00023336
		[global::Cpp2ILInjected.Token(Token = "0x6001380")]
		[global::Cpp2ILInjected.Address(RVA = "0xA8FEE4", Offset = "0xA8FEE4", Length = "0x8")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = ".ctor", ReturnType = typeof(void))]
		public TitleContainer()
		{
			throw null;
		}
	}
}
