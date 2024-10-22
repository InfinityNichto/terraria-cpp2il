﻿using System;
using System.Collections.Generic;
using System.IO;
using Cpp2ILInjected;
using Cpp2ILInjected.CallAnalysis;
using Terraria;
using Terraria.IO;

[global::Cpp2ILInjected.Token(Token = "0x20002CF")]
public class SaveSynchronisationState
{
	[global::Cpp2ILInjected.Token(Token = "0x600109E")]
	[global::Cpp2ILInjected.Address(RVA = "0xA493BC", Offset = "0xA493BC", Length = "0xE8")]
	[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(SaveSynchronisationManager), Member = "Startup", ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(SaveSynchronisationState), Member = "Clear", ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Main), Member = "LoadPlayers", ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(List<object>), Member = "AddRange", MemberParameters = new object[] { typeof(IEnumerable<object>) }, ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Main), Member = "LoadWorlds", ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 5)]
	public void RefreshFromFileSystem()
	{
		throw null;
	}

	[global::Cpp2ILInjected.Token(Token = "0x600109F")]
	[global::Cpp2ILInjected.Address(RVA = "0xA49540", Offset = "0xA49540", Length = "0x48")]
	[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
	[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(SaveSynchronisationClient), Member = "Update", ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(SaveSynchronisationManager), Member = "ProcessServerMessage", MemberParameters = new object[]
	{
		typeof(SaveSynchronisationOperation.MessageId),
		typeof(byte[]),
		typeof(SaveSynchronisationOperation.SendDataFunction)
	}, ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(SaveSynchronisationManager), Member = "ProcessClientMessage", MemberParameters = new object[]
	{
		typeof(SaveSynchronisationOperation.MessageId),
		typeof(byte[]),
		typeof(SaveSynchronisationOperation.SendDataFunction)
	}, ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 3)]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(SaveSynchronisationState), Member = "ReadWorldFileData", MemberParameters = new object[] { typeof(byte[]) }, ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
	public void ProcessMessage(SaveSynchronisationOperation.MessageId messageId, byte[] data)
	{
		throw null;
	}

	[global::Cpp2ILInjected.Token(Token = "0x60010A0")]
	[global::Cpp2ILInjected.Address(RVA = "0xA49E8C", Offset = "0xA49E8C", Length = "0xAC")]
	[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(SaveSynchronisationState), Member = "ProcessMessageResponse", MemberParameters = new object[]
	{
		typeof(SaveSynchronisationOperation.MessageId),
		typeof(SaveSynchronisationOperation.SendDataFunction)
	}, ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
	[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 3)]
	public void SendEmptyMessage(SaveSynchronisationOperation.MessageId id, SaveSynchronisationOperation.SendDataFunction sendDataFunction)
	{
		throw null;
	}

	[global::Cpp2ILInjected.Token(Token = "0x60010A1")]
	[global::Cpp2ILInjected.Address(RVA = "0xA49F38", Offset = "0xA49F38", Length = "0x18")]
	[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
	[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(SaveSynchronisationClient), Member = "Update", ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(SaveSynchronisationManager), Member = "ProcessServerMessage", MemberParameters = new object[]
	{
		typeof(SaveSynchronisationOperation.MessageId),
		typeof(byte[]),
		typeof(SaveSynchronisationOperation.SendDataFunction)
	}, ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(SaveSynchronisationManager), Member = "ProcessClientMessage", MemberParameters = new object[]
	{
		typeof(SaveSynchronisationOperation.MessageId),
		typeof(byte[]),
		typeof(SaveSynchronisationOperation.SendDataFunction)
	}, ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 3)]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(SaveSynchronisationState), Member = "SendEmptyMessage", MemberParameters = new object[]
	{
		typeof(SaveSynchronisationOperation.MessageId),
		typeof(SaveSynchronisationOperation.SendDataFunction)
	}, ReturnType = typeof(void))]
	public void ProcessMessageResponse(SaveSynchronisationOperation.MessageId messageId, SaveSynchronisationOperation.SendDataFunction sendDataFunction)
	{
		throw null;
	}

	[global::Cpp2ILInjected.Token(Token = "0x60010A2")]
	[global::Cpp2ILInjected.Address(RVA = "0xA49588", Offset = "0xA49588", Length = "0x440")]
	[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
	[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(MemoryStream), Member = ".ctor", MemberParameters = new object[] { typeof(byte[]) }, ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(BinaryReader), Member = ".ctor", MemberParameters = new object[] { typeof(Stream) }, ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(PlayerFileData), Member = ".ctor", ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(FileMetadata), Member = "Read", MemberParameters = new object[]
	{
		typeof(BinaryReader),
		typeof(FileType)
	}, ReturnType = typeof(FileMetadata))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Player), Member = ".ctor", ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(PlayerFileData), Member = "set_Player", MemberParameters = new object[] { typeof(Player) }, ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(SaveSynchronisationState), Member = "ReadPlayerData", MemberParameters = new object[]
	{
		typeof(BinaryReader),
		typeof(Player)
	}, ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Player), Member = "PlayerFrame", ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 24)]
	private void ReadPlayerFileData(byte[] data)
	{
		throw null;
	}

	[global::Cpp2ILInjected.Token(Token = "0x60010A3")]
	[global::Cpp2ILInjected.Address(RVA = "0xA49F50", Offset = "0xA49F50", Length = "0x8D8")]
	[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
	[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(SaveSynchronisationState), Member = "ReadPlayerFileData", MemberParameters = new object[] { typeof(byte[]) }, ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(BitsByte), Member = "op_Implicit", MemberParameters = new object[] { typeof(byte) }, ReturnType = typeof(BitsByte))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(BitsByte), Member = "get_Item", MemberParameters = new object[] { typeof(int) }, ReturnType = typeof(bool))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Player), Member = "set_UsingBiomeTorches", MemberParameters = new object[] { typeof(bool) }, ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Item), Member = "netDefaults", MemberParameters = new object[] { typeof(int) }, ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Item), Member = "Prefix", MemberParameters = new object[] { typeof(int) }, ReturnType = typeof(bool))]
	private void ReadPlayerData(BinaryReader reader, Player player)
	{
		throw null;
	}

	[global::Cpp2ILInjected.Token(Token = "0x60010A4")]
	[global::Cpp2ILInjected.Address(RVA = "0xA499C8", Offset = "0xA499C8", Length = "0x4C4")]
	[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
	[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(SaveSynchronisationState), Member = "ProcessMessage", MemberParameters = new object[]
	{
		typeof(SaveSynchronisationOperation.MessageId),
		typeof(byte[])
	}, ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(MemoryStream), Member = ".ctor", MemberParameters = new object[] { typeof(byte[]) }, ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(BinaryReader), Member = ".ctor", MemberParameters = new object[] { typeof(Stream) }, ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(WorldFileData), Member = ".ctor", ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(FileMetadata), Member = "Read", MemberParameters = new object[]
	{
		typeof(BinaryReader),
		typeof(FileType)
	}, ReturnType = typeof(FileMetadata))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(WorldFileData), Member = "SetWorldSize", MemberParameters = new object[]
	{
		typeof(int),
		typeof(int)
	}, ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(DateTime), Member = ".ctor", MemberParameters = new object[] { typeof(long) }, ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 22)]
	private void ReadWorldFileData(byte[] data)
	{
		throw null;
	}

	[global::Cpp2ILInjected.Token(Token = "0x60010A5")]
	[global::Cpp2ILInjected.Address(RVA = "0xA494A4", Offset = "0xA494A4", Length = "0x9C")]
	[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
	[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(SaveSynchronisationManager), Member = "Startup", ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(SaveSynchronisationState), Member = "RefreshFromFileSystem", ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 2)]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Array), Member = "Clear", MemberParameters = new object[]
	{
		typeof(Array),
		typeof(int),
		typeof(int)
	}, ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
	public void Clear()
	{
		throw null;
	}

	[global::Cpp2ILInjected.Token(Token = "0x60010A6")]
	[global::Cpp2ILInjected.Address(RVA = "0xA4A828", Offset = "0xA4A828", Length = "0xC4")]
	[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(SaveSynchronisationManager), Member = ".ctor", ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 2)]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(List<object>), Member = ".ctor", ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = ".ctor", ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 6)]
	public SaveSynchronisationState()
	{
		throw null;
	}

	// Note: this type is marked as 'beforefieldinit'.
	[global::Cpp2ILInjected.Token(Token = "0x60010A7")]
	[global::Cpp2ILInjected.Address(RVA = "0xA4A8EC", Offset = "0xA4A8EC", Length = "0x68")]
	[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
	[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 3)]
	static SaveSynchronisationState()
	{
		throw null;
	}

	[global::Cpp2ILInjected.Token(Token = "0x4001F7D")]
	private static byte[] emptyMessageData;

	[global::Cpp2ILInjected.Token(Token = "0x4001F7E")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x10")]
	public bool IsSynchronised;

	[global::Cpp2ILInjected.Token(Token = "0x4001F7F")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x18")]
	public List<PlayerFileData> playerFiles;

	[global::Cpp2ILInjected.Token(Token = "0x4001F80")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x20")]
	public List<WorldFileData> worldFiles;
}
