using System;
using System.IO;
using Cpp2ILInjected;
using Cpp2ILInjected.CallAnalysis;
using Microsoft.Xna.Framework;
using Terraria.GameContent.NetModules;
using Terraria.Net;

namespace Terraria.GameContent.Drawing
{
	[global::Cpp2ILInjected.Token(Token = "0x20009E7")]
	public struct ParticleOrchestraSettings
	{
		[global::Cpp2ILInjected.Token(Token = "0x6004ACC")]
		[global::Cpp2ILInjected.Address(RVA = "0x8A38BC", Offset = "0x8A38BC", Length = "0xB4")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(NetParticlesModule), Member = "Serialize", MemberParameters = new object[]
		{
			typeof(ParticleOrchestraType),
			typeof(ParticleOrchestraSettings)
		}, ReturnType = typeof(NetPacket))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Utils), Member = "WriteVector2", MemberParameters = new object[]
		{
			typeof(BinaryWriter),
			typeof(Vector2)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 3)]
		public void Serialize(BinaryWriter writer)
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x6004ACD")]
		[global::Cpp2ILInjected.Address(RVA = "0x8A3970", Offset = "0x8A3970", Length = "0xA8")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(NetParticlesModule), Member = "Deserialize", MemberParameters = new object[]
		{
			typeof(BinaryReader),
			typeof(int)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Utils), Member = "ReadVector2", MemberParameters = new object[] { typeof(BinaryReader) }, ReturnType = typeof(Vector2))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
		public void DeserializeFrom(BinaryReader reader)
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x400854D")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x0")]
		public Vector2 PositionInWorld;

		[global::Cpp2ILInjected.Token(Token = "0x400854E")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x8")]
		public Vector2 MovementVector;

		[global::Cpp2ILInjected.Token(Token = "0x400854F")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x10")]
		public int UniqueInfoPiece;

		[global::Cpp2ILInjected.Token(Token = "0x4008550")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x14")]
		public byte IndexOfPlayerWhoInvokedThis;

		[global::Cpp2ILInjected.Token(Token = "0x4008551")]
		public const int SerializationSize = 21;
	}
}
