using System;
using System.Globalization;
using Cpp2ILInjected;
using Cpp2ILInjected.CallAnalysis;
using Microsoft.Xna.Framework.Graphics;
using Terraria.UI.Chat;

namespace Terraria.GameContent.UI.Chat
{
	// Token: 0x020006ED RID: 1773
	[global::Cpp2ILInjected.Token(Token = "0x2000AD8")]
	public class ColorTagHandler : ITagHandler
	{
		// Token: 0x0600453B RID: 17723 RVA: 0x0002E64C File Offset: 0x0002C84C
		[global::Cpp2ILInjected.Token(Token = "0x60051A4")]
		[global::Cpp2ILInjected.Address(RVA = "0x931CBC", Offset = "0x931CBC", Length = "0xE4")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(TextSnippet), Member = ".ctor", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(CultureInfo), Member = "get_InvariantCulture", ReturnType = typeof(CultureInfo))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(int), Member = "TryParse", MemberParameters = new object[]
		{
			typeof(string),
			typeof(NumberStyles),
			typeof(IFormatProvider),
			typeof(ref int)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Color), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(int),
			typeof(int),
			typeof(int)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 4)]
		private TextSnippet Terraria.UI.Chat.ITagHandler.Parse(string text, Color baseColor, string options)
		{
			throw null;
		}

		// Token: 0x0600453C RID: 17724 RVA: 0x0002E64F File Offset: 0x0002C84F
		[global::Cpp2ILInjected.Token(Token = "0x60051A5")]
		[global::Cpp2ILInjected.Address(RVA = "0x931DA0", Offset = "0x931DA0", Length = "0x8")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = ".ctor", ReturnType = typeof(void))]
		public ColorTagHandler()
		{
			throw null;
		}
	}
}
