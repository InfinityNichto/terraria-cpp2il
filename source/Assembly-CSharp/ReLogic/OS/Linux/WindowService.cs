using System;
using Cpp2ILInjected;
using Cpp2ILInjected.CallAnalysis;
using Microsoft.Xna.Framework;

namespace ReLogic.OS.Linux
{
	// Token: 0x0200072D RID: 1837
	[global::Cpp2ILInjected.Token(Token = "0x2000B2C")]
	internal class WindowService : IWindowService
	{
		// Token: 0x060046B7 RID: 18103 RVA: 0x0002EA63 File Offset: 0x0002CC63
		[global::Cpp2ILInjected.Token(Token = "0x600536C")]
		[global::Cpp2ILInjected.Address(RVA = "0x944548", Offset = "0x944548", Length = "0x10")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(GameWindow), Member = "set_Title", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
		public void SetUnicodeTitle(GameWindow window, string title)
		{
			throw null;
		}

		// Token: 0x060046B8 RID: 18104 RVA: 0x0002EA66 File Offset: 0x0002CC66
		[global::Cpp2ILInjected.Token(Token = "0x600536D")]
		[global::Cpp2ILInjected.Address(RVA = "0x944558", Offset = "0x944558", Length = "0x4")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		public void StartFlashingIcon(GameWindow window)
		{
			throw null;
		}

		// Token: 0x060046B9 RID: 18105 RVA: 0x0002EA69 File Offset: 0x0002CC69
		[global::Cpp2ILInjected.Token(Token = "0x600536E")]
		[global::Cpp2ILInjected.Address(RVA = "0x94455C", Offset = "0x94455C", Length = "0x4")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		public void StopFlashingIcon(GameWindow window)
		{
			throw null;
		}

		// Token: 0x060046BA RID: 18106 RVA: 0x0002EA6C File Offset: 0x0002CC6C
		[global::Cpp2ILInjected.Token(Token = "0x600536F")]
		[global::Cpp2ILInjected.Address(RVA = "0x944560", Offset = "0x944560", Length = "0x8")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		public float GetScaling()
		{
			throw null;
		}

		// Token: 0x060046BB RID: 18107 RVA: 0x0002EA6F File Offset: 0x0002CC6F
		[global::Cpp2ILInjected.Token(Token = "0x6005370")]
		[global::Cpp2ILInjected.Address(RVA = "0x944568", Offset = "0x944568", Length = "0x4")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		public void SetQuickEditEnabled(bool enabled)
		{
			throw null;
		}

		// Token: 0x060046BC RID: 18108 RVA: 0x0002EA72 File Offset: 0x0002CC72
		[global::Cpp2ILInjected.Token(Token = "0x6005371")]
		[global::Cpp2ILInjected.Address(RVA = "0x94456C", Offset = "0x94456C", Length = "0x8")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = ".ctor", ReturnType = typeof(void))]
		public WindowService()
		{
			throw null;
		}
	}
}
