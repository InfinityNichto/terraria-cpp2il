using System;
using Cpp2ILInjected;
using Cpp2ILInjected.CallAnalysis;

namespace Terraria.Audio
{
	[global::Cpp2ILInjected.Token(Token = "0x2000685")]
	public class ProjectileAudioTracker
	{
		[global::Cpp2ILInjected.Token(Token = "0x60037BB")]
		[global::Cpp2ILInjected.Address(RVA = "0x14213F0", Offset = "0x14213F0", Length = "0x34")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Projectile), Member = "AI_195_JimsDrone", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = ".ctor", ReturnType = typeof(void))]
		public ProjectileAudioTracker(Projectile proj)
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x60037BC")]
		[global::Cpp2ILInjected.Address(RVA = "0x1421424", Offset = "0x1421424", Length = "0xA4")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Main), Member = "get_gameMenu", ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 3)]
		public bool IsActiveAndInGame()
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x40078A8")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x10")]
		private int _expectedType;

		[global::Cpp2ILInjected.Token(Token = "0x40078A9")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x14")]
		private int _expectedIndex;
	}
}
