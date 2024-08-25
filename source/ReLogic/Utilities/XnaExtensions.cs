using System;
using Cpp2ILInjected;
using Cpp2ILInjected.CallAnalysis;
using Microsoft.Xna.Framework.Audio;
using Microsoft.Xna.Framework.Graphics;
using ReLogic.Content;
using Terraria;
using Terraria.Audio;
using Terraria.IO;

namespace ReLogic.Utilities
{
	[global::Cpp2ILInjected.Token(Token = "0x2000B0E")]
	public static class XnaExtensions
	{
		[global::Cpp2ILInjected.Token(Token = "0x6005301")]
		[global::Cpp2ILInjected.Address(RVA = "0x15AB14C", Offset = "0x15AB14C", Length = "0x150")]
		[global::Cpp2ILInjected.CallAnalysis.DeduplicatedMethod]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Main), Member = "LoadContent", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(ResourcePack), Member = "CreateIcon", ReturnType = typeof(Texture2D))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(LegacySoundPlayer), Member = "Load", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(Asset<SoundEffect>))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 5)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Type), Member = "GetTypeFromHandle", MemberParameters = new object[] { typeof(RuntimeTypeHandle) }, ReturnType = typeof(Type))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 9)]
		public static T Get<T>(this IServiceProvider services) where T : class
		{
			throw null;
		}
	}
}
