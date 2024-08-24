﻿using System;
using System.IO;
using Cpp2ILInjected;
using Cpp2ILInjected.CallAnalysis;
using Microsoft.Xna.Framework.Graphics;

namespace Terraria.Map
{
	// Token: 0x020004A9 RID: 1193
	[global::Cpp2ILInjected.Token(Token = "0x20006BC")]
	public struct MapTile
	{
		// Token: 0x17000652 RID: 1618
		// (get) Token: 0x060033BF RID: 13247 RVA: 0x0002B3C4 File Offset: 0x000295C4
		// (set) Token: 0x060033C0 RID: 13248 RVA: 0x0002B3C7 File Offset: 0x000295C7
		[global::Cpp2ILInjected.Token(Token = "0x170006DA")]
		public bool IsChanged
		{
			[global::Cpp2ILInjected.Token(Token = "0x6003918")]
			[global::Cpp2ILInjected.Address(RVA = "0x1448310", Offset = "0x1448310", Length = "0x10")]
			[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			get
			{
				throw null;
			}
			[global::Cpp2ILInjected.Token(Token = "0x6003919")]
			[global::Cpp2ILInjected.Address(RVA = "0x1448320", Offset = "0x1448320", Length = "0x1C")]
			[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			set
			{
				throw null;
			}
		}

		// Token: 0x17000653 RID: 1619
		// (get) Token: 0x060033C1 RID: 13249 RVA: 0x0002B3CA File Offset: 0x000295CA
		// (set) Token: 0x060033C2 RID: 13250 RVA: 0x0002B3CD File Offset: 0x000295CD
		[global::Cpp2ILInjected.Token(Token = "0x170006DB")]
		public byte Color
		{
			[global::Cpp2ILInjected.Token(Token = "0x600391A")]
			[global::Cpp2ILInjected.Address(RVA = "0x144833C", Offset = "0x144833C", Length = "0xC")]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(GUIMap), Member = "DrawToMap", ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(GUIMap), Member = "ApplySection", MemberParameters = new object[]
			{
				typeof(int),
				typeof(int),
				typeof(int),
				typeof(int)
			}, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(GUIMap), Member = "DrawToMap_Section", MemberParameters = new object[]
			{
				typeof(int),
				typeof(int)
			}, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(MapHelper), Member = "GetMapTileXnaColor", MemberParameters = new object[] { typeof(ref MapTile) }, ReturnType = typeof(Color))]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 6)]
			get
			{
				throw null;
			}
			[global::Cpp2ILInjected.Token(Token = "0x600391B")]
			[global::Cpp2ILInjected.Address(RVA = "0x1448348", Offset = "0x1448348", Length = "0x10")]
			[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			set
			{
				throw null;
			}
		}

		// Token: 0x060033C3 RID: 13251 RVA: 0x0002B3D0 File Offset: 0x000295D0
		[global::Cpp2ILInjected.Token(Token = "0x600391C")]
		[global::Cpp2ILInjected.Address(RVA = "0x1448358", Offset = "0x1448358", Length = "0x10")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		private MapTile(ushort type, byte light, byte extraData)
		{
			throw null;
		}

		// Token: 0x060033C4 RID: 13252 RVA: 0x0002B3D3 File Offset: 0x000295D3
		[global::Cpp2ILInjected.Token(Token = "0x600391D")]
		[global::Cpp2ILInjected.Address(RVA = "0x1448368", Offset = "0x1448368", Length = "0x40")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		public bool Equals(ref MapTile other)
		{
			throw null;
		}

		// Token: 0x060033C5 RID: 13253 RVA: 0x0002B3D6 File Offset: 0x000295D6
		[global::Cpp2ILInjected.Token(Token = "0x600391E")]
		[global::Cpp2ILInjected.Address(RVA = "0x14483A8", Offset = "0x14483A8", Length = "0x30")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		public bool EqualsWithoutLight(ref MapTile other)
		{
			throw null;
		}

		// Token: 0x060033C6 RID: 13254 RVA: 0x0002B3D9 File Offset: 0x000295D9
		[global::Cpp2ILInjected.Token(Token = "0x600391F")]
		[global::Cpp2ILInjected.Address(RVA = "0x14483D8", Offset = "0x14483D8", Length = "0x8")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		public void Clear()
		{
			throw null;
		}

		// Token: 0x060033C7 RID: 13255 RVA: 0x0002B3DC File Offset: 0x000295DC
		[global::Cpp2ILInjected.Token(Token = "0x6003920")]
		[global::Cpp2ILInjected.Address(RVA = "0x14483E0", Offset = "0x14483E0", Length = "0x1C")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		public MapTile WithLight(byte light)
		{
			throw null;
		}

		// Token: 0x060033C8 RID: 13256 RVA: 0x0002B3DF File Offset: 0x000295DF
		[global::Cpp2ILInjected.Token(Token = "0x6003921")]
		[global::Cpp2ILInjected.Address(RVA = "0x14483FC", Offset = "0x14483FC", Length = "0x1C")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(MapHelper), Member = "CreateMapTile", MemberParameters = new object[]
		{
			typeof(int),
			typeof(int),
			typeof(byte)
		}, ReturnType = typeof(MapTile))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(MapHelper), Member = "LoadMapVersion1", MemberParameters = new object[]
		{
			typeof(BinaryReader),
			typeof(int)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 2)]
		public static MapTile Create(ushort type, byte light, byte color)
		{
			throw null;
		}

		// Token: 0x040065A0 RID: 26016
		[global::Cpp2ILInjected.Token(Token = "0x40079AF")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x0")]
		public ushort Type;

		// Token: 0x040065A1 RID: 26017
		[global::Cpp2ILInjected.Token(Token = "0x40079B0")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x2")]
		public byte Light;

		// Token: 0x040065A2 RID: 26018
		[global::Cpp2ILInjected.Token(Token = "0x40079B1")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x3")]
		public byte _extraData;
	}
}