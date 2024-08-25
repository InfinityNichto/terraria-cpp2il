using System;
using Cpp2ILInjected;
using Cpp2ILInjected.CallAnalysis;
using Microsoft.Xna.Framework;

namespace ReLogic.OS.Linux
{
	[global::Cpp2ILInjected.Token(Token = "0x2000B2C")]
	internal class WindowService : IWindowService
	{
		[global::Cpp2ILInjected.Token(Token = "0x600536C")]
		[global::Cpp2ILInjected.Address(RVA = "0x944548", Offset = "0x944548", Length = "0x10")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(GameWindow), Member = "set_Title", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
		public void SetUnicodeTitle(GameWindow window, string title)
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x600536D")]
		[global::Cpp2ILInjected.Address(RVA = "0x944558", Offset = "0x944558", Length = "0x4")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		public void StartFlashingIcon(GameWindow window)
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x600536E")]
		[global::Cpp2ILInjected.Address(RVA = "0x94455C", Offset = "0x94455C", Length = "0x4")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		public void StopFlashingIcon(GameWindow window)
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x600536F")]
		[global::Cpp2ILInjected.Address(RVA = "0x944560", Offset = "0x944560", Length = "0x8")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		public float GetScaling()
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x6005370")]
		[global::Cpp2ILInjected.Address(RVA = "0x944568", Offset = "0x944568", Length = "0x4")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		public void SetQuickEditEnabled(bool enabled)
		{
			throw null;
		}

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
