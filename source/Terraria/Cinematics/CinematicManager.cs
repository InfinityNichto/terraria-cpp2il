using System;
using System.Collections.Generic;
using Cpp2ILInjected;
using Cpp2ILInjected.CallAnalysis;
using Microsoft.Xna.Framework;

namespace Terraria.Cinematics
{
	[global::Cpp2ILInjected.Token(Token = "0x200078D")]
	public class CinematicManager
	{
		[global::Cpp2ILInjected.Token(Token = "0x6003F2A")]
		[global::Cpp2ILInjected.Address(RVA = "0x743468", Offset = "0x743468", Length = "0x13C")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Main), Member = "Update", MemberParameters = new object[] { typeof(GameTime) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(List<object>), Member = "get_Item", MemberParameters = new object[] { typeof(int) }, ReturnType = "T")]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Film), Member = "OnUpdate", MemberParameters = new object[] { typeof(GameTime) }, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(List<object>), Member = "RemoveAt", MemberParameters = new object[] { typeof(int) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 6)]
		public void Update(GameTime gameTime)
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x6003F2B")]
		[global::Cpp2ILInjected.Address(RVA = "0x743738", Offset = "0x743738", Length = "0xA8")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
		public void PlayFilm(Film film)
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x6003F2C")]
		[global::Cpp2ILInjected.Address(RVA = "0x7437E0", Offset = "0x7437E0", Length = "0x4")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		public void StopAll()
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x6003F2D")]
		[global::Cpp2ILInjected.Address(RVA = "0x7437E4", Offset = "0x7437E4", Length = "0x7C")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(CinematicManager), Member = ".cctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(List<object>), Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 3)]
		public CinematicManager()
		{
			throw null;
		}

		// Note: this type is marked as 'beforefieldinit'.
		[global::Cpp2ILInjected.Token(Token = "0x6003F2E")]
		[global::Cpp2ILInjected.Address(RVA = "0x743860", Offset = "0x743860", Length = "0x58")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(CinematicManager), Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
		static CinematicManager()
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x4007DA2")]
		public static CinematicManager Instance;

		[global::Cpp2ILInjected.Token(Token = "0x4007DA3")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x10")]
		private List<Film> _films;
	}
}
