using System;
using Cpp2ILInjected;
using Cpp2ILInjected.CallAnalysis;
using Microsoft.Xna.Framework;

namespace ReLogic.OS.OSX
{
	// Token: 0x0200072A RID: 1834
	[global::Cpp2ILInjected.Token(Token = "0x2000B29")]
	internal class WindowService : IWindowService
	{
		// Token: 0x060046AB RID: 18091 RVA: 0x0002EA3F File Offset: 0x0002CC3F
		[global::Cpp2ILInjected.Token(Token = "0x6005360")]
		[global::Cpp2ILInjected.Address(RVA = "0x943BC0", Offset = "0x943BC0", Length = "0x8")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		public float GetScaling()
		{
			throw null;
		}

		// Token: 0x060046AC RID: 18092 RVA: 0x0002EA42 File Offset: 0x0002CC42
		[global::Cpp2ILInjected.Token(Token = "0x6005361")]
		[global::Cpp2ILInjected.Address(RVA = "0x943BC8", Offset = "0x943BC8", Length = "0x4")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		public void SetQuickEditEnabled(bool enabled)
		{
			throw null;
		}

		// Token: 0x060046AD RID: 18093 RVA: 0x0002EA45 File Offset: 0x0002CC45
		[global::Cpp2ILInjected.Token(Token = "0x6005362")]
		[global::Cpp2ILInjected.Address(RVA = "0x943BCC", Offset = "0x943BCC", Length = "0x10")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(GameWindow), Member = "set_Title", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
		public void SetUnicodeTitle(GameWindow window, string title)
		{
			throw null;
		}

		// Token: 0x060046AE RID: 18094 RVA: 0x0002EA48 File Offset: 0x0002CC48
		[global::Cpp2ILInjected.Token(Token = "0x6005363")]
		[global::Cpp2ILInjected.Address(RVA = "0x943BDC", Offset = "0x943BDC", Length = "0x4")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		public void StartFlashingIcon(GameWindow window)
		{
			throw null;
		}

		// Token: 0x060046AF RID: 18095 RVA: 0x0002EA4B File Offset: 0x0002CC4B
		[global::Cpp2ILInjected.Token(Token = "0x6005364")]
		[global::Cpp2ILInjected.Address(RVA = "0x943BE0", Offset = "0x943BE0", Length = "0x4")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		public void StopFlashingIcon(GameWindow window)
		{
			throw null;
		}

		// Token: 0x060046B0 RID: 18096 RVA: 0x0002EA4E File Offset: 0x0002CC4E
		[global::Cpp2ILInjected.Token(Token = "0x6005365")]
		[global::Cpp2ILInjected.Address(RVA = "0x943BE4", Offset = "0x943BE4", Length = "0x8")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = ".ctor", ReturnType = typeof(void))]
		public WindowService()
		{
			throw null;
		}
	}
}
