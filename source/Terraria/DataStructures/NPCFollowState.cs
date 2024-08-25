using System;
using System.IO;
using Cpp2ILInjected;
using Cpp2ILInjected.CallAnalysis;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;

namespace Terraria.DataStructures
{
	[global::Cpp2ILInjected.Token(Token = "0x2000639")]
	public class NPCFollowState
	{
		[global::Cpp2ILInjected.Token(Token = "0x1700069E")]
		public Vector2 BreadcrumbPosition
		{
			[global::Cpp2ILInjected.Token(Token = "0x6003639")]
			[global::Cpp2ILInjected.Address(RVA = "0x13DD2C0", Offset = "0x13DD2C0", Length = "0x8")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			get
			{
				throw null;
			}
		}

		[global::Cpp2ILInjected.Token(Token = "0x1700069F")]
		public bool IsFollowingPlayer
		{
			[global::Cpp2ILInjected.Token(Token = "0x600363A")]
			[global::Cpp2ILInjected.Address(RVA = "0x13DD2C8", Offset = "0x13DD2C8", Length = "0x3C")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
			get
			{
				throw null;
			}
		}

		[global::Cpp2ILInjected.Token(Token = "0x170006A0")]
		public Player PlayerBeingFollowed
		{
			[global::Cpp2ILInjected.Token(Token = "0x600363B")]
			[global::Cpp2ILInjected.Address(RVA = "0x13DD304", Offset = "0x13DD304", Length = "0xA0")]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(NPCFollowState), Member = "Update", ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(int?), Member = "get_Value", ReturnType = "T")]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 4)]
			get
			{
				throw null;
			}
		}

		[global::Cpp2ILInjected.Token(Token = "0x600363C")]
		[global::Cpp2ILInjected.Address(RVA = "0x13DD3A4", Offset = "0x13DD3A4", Length = "0xC0")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(int?), Member = ".ctor", MemberParameters = new object[] { typeof(int) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Entity), Member = "get_Bottom", ReturnType = typeof(Vector2))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 3)]
		public void FollowPlayer(int playerIndex)
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x600363D")]
		[global::Cpp2ILInjected.Address(RVA = "0x13DD464", Offset = "0x13DD464", Length = "0x24")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		public void StopFollowing()
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x600363E")]
		[global::Cpp2ILInjected.Address(RVA = "0x13DD4A8", Offset = "0x13DD4A8", Length = "0xC")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		public void Clear(NPC npcToBelongTo)
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x600363F")]
		[global::Cpp2ILInjected.Address(RVA = "0x13DD4B4", Offset = "0x13DD4B4", Length = "0xC")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(NPC), Member = "get_isLikeATownNPC", ReturnType = typeof(bool))]
		private bool ShouldSync()
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x6003640")]
		[global::Cpp2ILInjected.Address(RVA = "0x13DD4C0", Offset = "0x13DD4C0", Length = "0x80")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(int?), Member = "get_Value", ReturnType = "T")]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 3)]
		public void WriteTo(BinaryWriter writer)
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x6003641")]
		[global::Cpp2ILInjected.Address(RVA = "0x13DD540", Offset = "0x13DD540", Length = "0x104")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Utils[]), Member = "IndexInRange", MemberTypeParameters = new object[] { typeof(object) }, MemberParameters = new object[]
		{
			typeof(object[]),
			typeof(int)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(int?), Member = ".ctor", MemberParameters = new object[] { typeof(int) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 6)]
		public void ReadFrom(BinaryReader reader)
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x6003642")]
		[global::Cpp2ILInjected.Address(RVA = "0x13DD488", Offset = "0x13DD488", Length = "0x20")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		private void MoveNPCBackHome()
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x6003643")]
		[global::Cpp2ILInjected.Address(RVA = "0x13DD644", Offset = "0x13DD644", Length = "0x11C")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(NPCFollowState), Member = "get_PlayerBeingFollowed", ReturnType = typeof(Player))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(NPCFollowState), Member = "UpdateBreadcrumbs", MemberParameters = new object[] { typeof(Player) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Dust), Member = "QuickDust", MemberParameters = new object[]
		{
			typeof(Vector2),
			typeof(Color)
		}, ReturnType = typeof(Dust))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 5)]
		public void Update()
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x6003644")]
		[global::Cpp2ILInjected.Address(RVA = "0x13DD760", Offset = "0x13DD760", Length = "0x13C")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(NPCFollowState), Member = "Update", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Entity), Member = "get_Bottom", ReturnType = typeof(Vector2))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Vector2?), Member = ".ctor", MemberParameters = new object[] { typeof(Vector2) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Vector2?), Member = "get_Value", ReturnType = "T")]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Vector2), Member = "Distance", MemberParameters = new object[]
		{
			typeof(Vector2),
			typeof(Vector2)
		}, ReturnType = typeof(float))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 5)]
		private void UpdateBreadcrumbs(Player player)
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x6003645")]
		[global::Cpp2ILInjected.Address(RVA = "0x13DD89C", Offset = "0x13DD89C", Length = "0x8")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = ".ctor", ReturnType = typeof(void))]
		public NPCFollowState()
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x40076FB")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x10")]
		private NPC _npc;

		[global::Cpp2ILInjected.Token(Token = "0x40076FC")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x18")]
		private int? _playerIndexBeingFollowed;

		[global::Cpp2ILInjected.Token(Token = "0x40076FD")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x20")]
		private Vector2 _floorBreadcrumb;
	}
}
