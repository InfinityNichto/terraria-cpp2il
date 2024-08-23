using System;
using System.ComponentModel;
using Cpp2ILInjected;

namespace UnityEngine.Experimental.Rendering
{
	// Token: 0x02000119 RID: 281
	[global::Cpp2ILInjected.Token(Token = "0x200013E")]
	public enum GraphicsFormat
	{
		// Token: 0x0400052B RID: 1323
		[global::Cpp2ILInjected.Token(Token = "0x400057A")]
		None,
		// Token: 0x0400052C RID: 1324
		[global::Cpp2ILInjected.Token(Token = "0x400057B")]
		R8_SRGB,
		// Token: 0x0400052D RID: 1325
		[global::Cpp2ILInjected.Token(Token = "0x400057C")]
		R8G8_SRGB,
		// Token: 0x0400052E RID: 1326
		[global::Cpp2ILInjected.Token(Token = "0x400057D")]
		R8G8B8_SRGB,
		// Token: 0x0400052F RID: 1327
		[global::Cpp2ILInjected.Token(Token = "0x400057E")]
		R8G8B8A8_SRGB,
		// Token: 0x04000530 RID: 1328
		[global::Cpp2ILInjected.Token(Token = "0x400057F")]
		R8_UNorm,
		// Token: 0x04000531 RID: 1329
		[global::Cpp2ILInjected.Token(Token = "0x4000580")]
		R8G8_UNorm,
		// Token: 0x04000532 RID: 1330
		[global::Cpp2ILInjected.Token(Token = "0x4000581")]
		R8G8B8_UNorm,
		// Token: 0x04000533 RID: 1331
		[global::Cpp2ILInjected.Token(Token = "0x4000582")]
		R8G8B8A8_UNorm,
		// Token: 0x04000534 RID: 1332
		[global::Cpp2ILInjected.Token(Token = "0x4000583")]
		R8_SNorm,
		// Token: 0x04000535 RID: 1333
		[global::Cpp2ILInjected.Token(Token = "0x4000584")]
		R8G8_SNorm,
		// Token: 0x04000536 RID: 1334
		[global::Cpp2ILInjected.Token(Token = "0x4000585")]
		R8G8B8_SNorm,
		// Token: 0x04000537 RID: 1335
		[global::Cpp2ILInjected.Token(Token = "0x4000586")]
		R8G8B8A8_SNorm,
		// Token: 0x04000538 RID: 1336
		[global::Cpp2ILInjected.Token(Token = "0x4000587")]
		R8_UInt,
		// Token: 0x04000539 RID: 1337
		[global::Cpp2ILInjected.Token(Token = "0x4000588")]
		R8G8_UInt,
		// Token: 0x0400053A RID: 1338
		[global::Cpp2ILInjected.Token(Token = "0x4000589")]
		R8G8B8_UInt,
		// Token: 0x0400053B RID: 1339
		[global::Cpp2ILInjected.Token(Token = "0x400058A")]
		R8G8B8A8_UInt,
		// Token: 0x0400053C RID: 1340
		[global::Cpp2ILInjected.Token(Token = "0x400058B")]
		R8_SInt,
		// Token: 0x0400053D RID: 1341
		[global::Cpp2ILInjected.Token(Token = "0x400058C")]
		R8G8_SInt,
		// Token: 0x0400053E RID: 1342
		[global::Cpp2ILInjected.Token(Token = "0x400058D")]
		R8G8B8_SInt,
		// Token: 0x0400053F RID: 1343
		[global::Cpp2ILInjected.Token(Token = "0x400058E")]
		R8G8B8A8_SInt,
		// Token: 0x04000540 RID: 1344
		[global::Cpp2ILInjected.Token(Token = "0x400058F")]
		R16_UNorm,
		// Token: 0x04000541 RID: 1345
		[global::Cpp2ILInjected.Token(Token = "0x4000590")]
		R16G16_UNorm,
		// Token: 0x04000542 RID: 1346
		[global::Cpp2ILInjected.Token(Token = "0x4000591")]
		R16G16B16_UNorm,
		// Token: 0x04000543 RID: 1347
		[global::Cpp2ILInjected.Token(Token = "0x4000592")]
		R16G16B16A16_UNorm,
		// Token: 0x04000544 RID: 1348
		[global::Cpp2ILInjected.Token(Token = "0x4000593")]
		R16_SNorm,
		// Token: 0x04000545 RID: 1349
		[global::Cpp2ILInjected.Token(Token = "0x4000594")]
		R16G16_SNorm,
		// Token: 0x04000546 RID: 1350
		[global::Cpp2ILInjected.Token(Token = "0x4000595")]
		R16G16B16_SNorm,
		// Token: 0x04000547 RID: 1351
		[global::Cpp2ILInjected.Token(Token = "0x4000596")]
		R16G16B16A16_SNorm,
		// Token: 0x04000548 RID: 1352
		[global::Cpp2ILInjected.Token(Token = "0x4000597")]
		R16_UInt,
		// Token: 0x04000549 RID: 1353
		[global::Cpp2ILInjected.Token(Token = "0x4000598")]
		R16G16_UInt,
		// Token: 0x0400054A RID: 1354
		[global::Cpp2ILInjected.Token(Token = "0x4000599")]
		R16G16B16_UInt,
		// Token: 0x0400054B RID: 1355
		[global::Cpp2ILInjected.Token(Token = "0x400059A")]
		R16G16B16A16_UInt,
		// Token: 0x0400054C RID: 1356
		[global::Cpp2ILInjected.Token(Token = "0x400059B")]
		R16_SInt,
		// Token: 0x0400054D RID: 1357
		[global::Cpp2ILInjected.Token(Token = "0x400059C")]
		R16G16_SInt,
		// Token: 0x0400054E RID: 1358
		[global::Cpp2ILInjected.Token(Token = "0x400059D")]
		R16G16B16_SInt,
		// Token: 0x0400054F RID: 1359
		[global::Cpp2ILInjected.Token(Token = "0x400059E")]
		R16G16B16A16_SInt,
		// Token: 0x04000550 RID: 1360
		[global::Cpp2ILInjected.Token(Token = "0x400059F")]
		R32_UInt,
		// Token: 0x04000551 RID: 1361
		[global::Cpp2ILInjected.Token(Token = "0x40005A0")]
		R32G32_UInt,
		// Token: 0x04000552 RID: 1362
		[global::Cpp2ILInjected.Token(Token = "0x40005A1")]
		R32G32B32_UInt,
		// Token: 0x04000553 RID: 1363
		[global::Cpp2ILInjected.Token(Token = "0x40005A2")]
		R32G32B32A32_UInt,
		// Token: 0x04000554 RID: 1364
		[global::Cpp2ILInjected.Token(Token = "0x40005A3")]
		R32_SInt,
		// Token: 0x04000555 RID: 1365
		[global::Cpp2ILInjected.Token(Token = "0x40005A4")]
		R32G32_SInt,
		// Token: 0x04000556 RID: 1366
		[global::Cpp2ILInjected.Token(Token = "0x40005A5")]
		R32G32B32_SInt,
		// Token: 0x04000557 RID: 1367
		[global::Cpp2ILInjected.Token(Token = "0x40005A6")]
		R32G32B32A32_SInt,
		// Token: 0x04000558 RID: 1368
		[global::Cpp2ILInjected.Token(Token = "0x40005A7")]
		R16_SFloat,
		// Token: 0x04000559 RID: 1369
		[global::Cpp2ILInjected.Token(Token = "0x40005A8")]
		R16G16_SFloat,
		// Token: 0x0400055A RID: 1370
		[global::Cpp2ILInjected.Token(Token = "0x40005A9")]
		R16G16B16_SFloat,
		// Token: 0x0400055B RID: 1371
		[global::Cpp2ILInjected.Token(Token = "0x40005AA")]
		R16G16B16A16_SFloat,
		// Token: 0x0400055C RID: 1372
		[global::Cpp2ILInjected.Token(Token = "0x40005AB")]
		R32_SFloat,
		// Token: 0x0400055D RID: 1373
		[global::Cpp2ILInjected.Token(Token = "0x40005AC")]
		R32G32_SFloat,
		// Token: 0x0400055E RID: 1374
		[global::Cpp2ILInjected.Token(Token = "0x40005AD")]
		R32G32B32_SFloat,
		// Token: 0x0400055F RID: 1375
		[global::Cpp2ILInjected.Token(Token = "0x40005AE")]
		R32G32B32A32_SFloat,
		// Token: 0x04000560 RID: 1376
		[global::Cpp2ILInjected.Token(Token = "0x40005AF")]
		B8G8R8_SRGB = 56,
		// Token: 0x04000561 RID: 1377
		[global::Cpp2ILInjected.Token(Token = "0x40005B0")]
		B8G8R8A8_SRGB,
		// Token: 0x04000562 RID: 1378
		[global::Cpp2ILInjected.Token(Token = "0x40005B1")]
		B8G8R8_UNorm,
		// Token: 0x04000563 RID: 1379
		[global::Cpp2ILInjected.Token(Token = "0x40005B2")]
		B8G8R8A8_UNorm,
		// Token: 0x04000564 RID: 1380
		[global::Cpp2ILInjected.Token(Token = "0x40005B3")]
		B8G8R8_SNorm,
		// Token: 0x04000565 RID: 1381
		[global::Cpp2ILInjected.Token(Token = "0x40005B4")]
		B8G8R8A8_SNorm,
		// Token: 0x04000566 RID: 1382
		[global::Cpp2ILInjected.Token(Token = "0x40005B5")]
		B8G8R8_UInt,
		// Token: 0x04000567 RID: 1383
		[global::Cpp2ILInjected.Token(Token = "0x40005B6")]
		B8G8R8A8_UInt,
		// Token: 0x04000568 RID: 1384
		[global::Cpp2ILInjected.Token(Token = "0x40005B7")]
		B8G8R8_SInt,
		// Token: 0x04000569 RID: 1385
		[global::Cpp2ILInjected.Token(Token = "0x40005B8")]
		B8G8R8A8_SInt,
		// Token: 0x0400056A RID: 1386
		[global::Cpp2ILInjected.Token(Token = "0x40005B9")]
		R4G4B4A4_UNormPack16,
		// Token: 0x0400056B RID: 1387
		[global::Cpp2ILInjected.Token(Token = "0x40005BA")]
		B4G4R4A4_UNormPack16,
		// Token: 0x0400056C RID: 1388
		[global::Cpp2ILInjected.Token(Token = "0x40005BB")]
		R5G6B5_UNormPack16,
		// Token: 0x0400056D RID: 1389
		[global::Cpp2ILInjected.Token(Token = "0x40005BC")]
		B5G6R5_UNormPack16,
		// Token: 0x0400056E RID: 1390
		[global::Cpp2ILInjected.Token(Token = "0x40005BD")]
		R5G5B5A1_UNormPack16,
		// Token: 0x0400056F RID: 1391
		[global::Cpp2ILInjected.Token(Token = "0x40005BE")]
		B5G5R5A1_UNormPack16,
		// Token: 0x04000570 RID: 1392
		[global::Cpp2ILInjected.Token(Token = "0x40005BF")]
		A1R5G5B5_UNormPack16,
		// Token: 0x04000571 RID: 1393
		[global::Cpp2ILInjected.Token(Token = "0x40005C0")]
		E5B9G9R9_UFloatPack32,
		// Token: 0x04000572 RID: 1394
		[global::Cpp2ILInjected.Token(Token = "0x40005C1")]
		B10G11R11_UFloatPack32,
		// Token: 0x04000573 RID: 1395
		[global::Cpp2ILInjected.Token(Token = "0x40005C2")]
		A2B10G10R10_UNormPack32,
		// Token: 0x04000574 RID: 1396
		[global::Cpp2ILInjected.Token(Token = "0x40005C3")]
		A2B10G10R10_UIntPack32,
		// Token: 0x04000575 RID: 1397
		[global::Cpp2ILInjected.Token(Token = "0x40005C4")]
		A2B10G10R10_SIntPack32,
		// Token: 0x04000576 RID: 1398
		[global::Cpp2ILInjected.Token(Token = "0x40005C5")]
		A2R10G10B10_UNormPack32,
		// Token: 0x04000577 RID: 1399
		[global::Cpp2ILInjected.Token(Token = "0x40005C6")]
		A2R10G10B10_UIntPack32,
		// Token: 0x04000578 RID: 1400
		[global::Cpp2ILInjected.Token(Token = "0x40005C7")]
		A2R10G10B10_SIntPack32,
		// Token: 0x04000579 RID: 1401
		[global::Cpp2ILInjected.Token(Token = "0x40005C8")]
		A2R10G10B10_XRSRGBPack32,
		// Token: 0x0400057A RID: 1402
		[global::Cpp2ILInjected.Token(Token = "0x40005C9")]
		A2R10G10B10_XRUNormPack32,
		// Token: 0x0400057B RID: 1403
		[global::Cpp2ILInjected.Token(Token = "0x40005CA")]
		R10G10B10_XRSRGBPack32,
		// Token: 0x0400057C RID: 1404
		[global::Cpp2ILInjected.Token(Token = "0x40005CB")]
		R10G10B10_XRUNormPack32,
		// Token: 0x0400057D RID: 1405
		[global::Cpp2ILInjected.Token(Token = "0x40005CC")]
		A10R10G10B10_XRSRGBPack32,
		// Token: 0x0400057E RID: 1406
		[global::Cpp2ILInjected.Token(Token = "0x40005CD")]
		A10R10G10B10_XRUNormPack32,
		// Token: 0x0400057F RID: 1407
		[global::Cpp2ILInjected.Token(Token = "0x40005CE")]
		D16_UNorm = 90,
		// Token: 0x04000580 RID: 1408
		[global::Cpp2ILInjected.Token(Token = "0x40005CF")]
		D24_UNorm,
		// Token: 0x04000581 RID: 1409
		[global::Cpp2ILInjected.Token(Token = "0x40005D0")]
		D24_UNorm_S8_UInt,
		// Token: 0x04000582 RID: 1410
		[global::Cpp2ILInjected.Token(Token = "0x40005D1")]
		D32_SFloat,
		// Token: 0x04000583 RID: 1411
		[global::Cpp2ILInjected.Token(Token = "0x40005D2")]
		D32_SFloat_S8_UInt,
		// Token: 0x04000584 RID: 1412
		[global::Cpp2ILInjected.Token(Token = "0x40005D3")]
		S8_UInt,
		// Token: 0x04000585 RID: 1413
		[EditorBrowsable(EditorBrowsableState.Never)]
		[Obsolete("Enum member GraphicsFormat.RGB_DXT1_SRGB has been deprecated. Use GraphicsFormat.RGBA_DXT1_SRGB instead (UnityUpgradable) -> RGBA_DXT1_SRGB", true)]
		[global::Cpp2ILInjected.Token(Token = "0x40005D4")]
		RGB_DXT1_SRGB,
		// Token: 0x04000586 RID: 1414
		[global::Cpp2ILInjected.Token(Token = "0x40005D5")]
		RGBA_DXT1_SRGB = 96,
		// Token: 0x04000587 RID: 1415
		[Obsolete("Enum member GraphicsFormat.RGB_DXT1_UNorm has been deprecated. Use GraphicsFormat.RGBA_DXT1_UNorm instead (UnityUpgradable) -> RGBA_DXT1_UNorm", true)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		[global::Cpp2ILInjected.Token(Token = "0x40005D6")]
		RGB_DXT1_UNorm,
		// Token: 0x04000588 RID: 1416
		[global::Cpp2ILInjected.Token(Token = "0x40005D7")]
		RGBA_DXT1_UNorm = 97,
		// Token: 0x04000589 RID: 1417
		[global::Cpp2ILInjected.Token(Token = "0x40005D8")]
		RGBA_DXT3_SRGB,
		// Token: 0x0400058A RID: 1418
		[global::Cpp2ILInjected.Token(Token = "0x40005D9")]
		RGBA_DXT3_UNorm,
		// Token: 0x0400058B RID: 1419
		[global::Cpp2ILInjected.Token(Token = "0x40005DA")]
		RGBA_DXT5_SRGB,
		// Token: 0x0400058C RID: 1420
		[global::Cpp2ILInjected.Token(Token = "0x40005DB")]
		RGBA_DXT5_UNorm,
		// Token: 0x0400058D RID: 1421
		[global::Cpp2ILInjected.Token(Token = "0x40005DC")]
		R_BC4_UNorm,
		// Token: 0x0400058E RID: 1422
		[global::Cpp2ILInjected.Token(Token = "0x40005DD")]
		R_BC4_SNorm,
		// Token: 0x0400058F RID: 1423
		[global::Cpp2ILInjected.Token(Token = "0x40005DE")]
		RG_BC5_UNorm,
		// Token: 0x04000590 RID: 1424
		[global::Cpp2ILInjected.Token(Token = "0x40005DF")]
		RG_BC5_SNorm,
		// Token: 0x04000591 RID: 1425
		[global::Cpp2ILInjected.Token(Token = "0x40005E0")]
		RGB_BC6H_UFloat,
		// Token: 0x04000592 RID: 1426
		[global::Cpp2ILInjected.Token(Token = "0x40005E1")]
		RGB_BC6H_SFloat,
		// Token: 0x04000593 RID: 1427
		[global::Cpp2ILInjected.Token(Token = "0x40005E2")]
		RGBA_BC7_SRGB,
		// Token: 0x04000594 RID: 1428
		[global::Cpp2ILInjected.Token(Token = "0x40005E3")]
		RGBA_BC7_UNorm,
		// Token: 0x04000595 RID: 1429
		[global::Cpp2ILInjected.Token(Token = "0x40005E4")]
		RGB_PVRTC_2Bpp_SRGB,
		// Token: 0x04000596 RID: 1430
		[global::Cpp2ILInjected.Token(Token = "0x40005E5")]
		RGB_PVRTC_2Bpp_UNorm,
		// Token: 0x04000597 RID: 1431
		[global::Cpp2ILInjected.Token(Token = "0x40005E6")]
		RGB_PVRTC_4Bpp_SRGB,
		// Token: 0x04000598 RID: 1432
		[global::Cpp2ILInjected.Token(Token = "0x40005E7")]
		RGB_PVRTC_4Bpp_UNorm,
		// Token: 0x04000599 RID: 1433
		[global::Cpp2ILInjected.Token(Token = "0x40005E8")]
		RGBA_PVRTC_2Bpp_SRGB,
		// Token: 0x0400059A RID: 1434
		[global::Cpp2ILInjected.Token(Token = "0x40005E9")]
		RGBA_PVRTC_2Bpp_UNorm,
		// Token: 0x0400059B RID: 1435
		[global::Cpp2ILInjected.Token(Token = "0x40005EA")]
		RGBA_PVRTC_4Bpp_SRGB,
		// Token: 0x0400059C RID: 1436
		[global::Cpp2ILInjected.Token(Token = "0x40005EB")]
		RGBA_PVRTC_4Bpp_UNorm,
		// Token: 0x0400059D RID: 1437
		[global::Cpp2ILInjected.Token(Token = "0x40005EC")]
		RGB_ETC_UNorm,
		// Token: 0x0400059E RID: 1438
		[global::Cpp2ILInjected.Token(Token = "0x40005ED")]
		RGB_ETC2_SRGB,
		// Token: 0x0400059F RID: 1439
		[global::Cpp2ILInjected.Token(Token = "0x40005EE")]
		RGB_ETC2_UNorm,
		// Token: 0x040005A0 RID: 1440
		[global::Cpp2ILInjected.Token(Token = "0x40005EF")]
		RGB_A1_ETC2_SRGB,
		// Token: 0x040005A1 RID: 1441
		[global::Cpp2ILInjected.Token(Token = "0x40005F0")]
		RGB_A1_ETC2_UNorm,
		// Token: 0x040005A2 RID: 1442
		[global::Cpp2ILInjected.Token(Token = "0x40005F1")]
		RGBA_ETC2_SRGB,
		// Token: 0x040005A3 RID: 1443
		[global::Cpp2ILInjected.Token(Token = "0x40005F2")]
		RGBA_ETC2_UNorm,
		// Token: 0x040005A4 RID: 1444
		[global::Cpp2ILInjected.Token(Token = "0x40005F3")]
		R_EAC_UNorm,
		// Token: 0x040005A5 RID: 1445
		[global::Cpp2ILInjected.Token(Token = "0x40005F4")]
		R_EAC_SNorm,
		// Token: 0x040005A6 RID: 1446
		[global::Cpp2ILInjected.Token(Token = "0x40005F5")]
		RG_EAC_UNorm,
		// Token: 0x040005A7 RID: 1447
		[global::Cpp2ILInjected.Token(Token = "0x40005F6")]
		RG_EAC_SNorm,
		// Token: 0x040005A8 RID: 1448
		[global::Cpp2ILInjected.Token(Token = "0x40005F7")]
		RGBA_ASTC4X4_SRGB,
		// Token: 0x040005A9 RID: 1449
		[global::Cpp2ILInjected.Token(Token = "0x40005F8")]
		RGBA_ASTC4X4_UNorm,
		// Token: 0x040005AA RID: 1450
		[global::Cpp2ILInjected.Token(Token = "0x40005F9")]
		RGBA_ASTC5X5_SRGB,
		// Token: 0x040005AB RID: 1451
		[global::Cpp2ILInjected.Token(Token = "0x40005FA")]
		RGBA_ASTC5X5_UNorm,
		// Token: 0x040005AC RID: 1452
		[global::Cpp2ILInjected.Token(Token = "0x40005FB")]
		RGBA_ASTC6X6_SRGB,
		// Token: 0x040005AD RID: 1453
		[global::Cpp2ILInjected.Token(Token = "0x40005FC")]
		RGBA_ASTC6X6_UNorm,
		// Token: 0x040005AE RID: 1454
		[global::Cpp2ILInjected.Token(Token = "0x40005FD")]
		RGBA_ASTC8X8_SRGB,
		// Token: 0x040005AF RID: 1455
		[global::Cpp2ILInjected.Token(Token = "0x40005FE")]
		RGBA_ASTC8X8_UNorm,
		// Token: 0x040005B0 RID: 1456
		[global::Cpp2ILInjected.Token(Token = "0x40005FF")]
		RGBA_ASTC10X10_SRGB,
		// Token: 0x040005B1 RID: 1457
		[global::Cpp2ILInjected.Token(Token = "0x4000600")]
		RGBA_ASTC10X10_UNorm,
		// Token: 0x040005B2 RID: 1458
		[global::Cpp2ILInjected.Token(Token = "0x4000601")]
		RGBA_ASTC12X12_SRGB,
		// Token: 0x040005B3 RID: 1459
		[global::Cpp2ILInjected.Token(Token = "0x4000602")]
		RGBA_ASTC12X12_UNorm,
		// Token: 0x040005B4 RID: 1460
		[global::Cpp2ILInjected.Token(Token = "0x4000603")]
		YUV2,
		// Token: 0x040005B5 RID: 1461
		[Obsolete("Enum member GraphicsFormat.DepthAuto has been deprecated. Use GraphicsFormat.None as a color format to indicate depth only rendering and DefaultFormat to get the default depth buffer format.", false)]
		[global::Cpp2ILInjected.Token(Token = "0x4000604")]
		DepthAuto,
		// Token: 0x040005B6 RID: 1462
		[Obsolete("Enum member GraphicsFormat.ShadowAuto has been deprecated. Use GraphicsFormat.None as a color format to indicate depth only rendering and DefaultFormat to get the default shadow buffer format.", false)]
		[global::Cpp2ILInjected.Token(Token = "0x4000605")]
		ShadowAuto,
		// Token: 0x040005B7 RID: 1463
		[Obsolete("Enum member GraphicsFormat.VideoAuto has been deprecated. Use DefaultFormat instead.", false)]
		[global::Cpp2ILInjected.Token(Token = "0x4000606")]
		VideoAuto,
		// Token: 0x040005B8 RID: 1464
		[global::Cpp2ILInjected.Token(Token = "0x4000607")]
		RGBA_ASTC4X4_UFloat,
		// Token: 0x040005B9 RID: 1465
		[global::Cpp2ILInjected.Token(Token = "0x4000608")]
		RGBA_ASTC5X5_UFloat,
		// Token: 0x040005BA RID: 1466
		[global::Cpp2ILInjected.Token(Token = "0x4000609")]
		RGBA_ASTC6X6_UFloat,
		// Token: 0x040005BB RID: 1467
		[global::Cpp2ILInjected.Token(Token = "0x400060A")]
		RGBA_ASTC8X8_UFloat,
		// Token: 0x040005BC RID: 1468
		[global::Cpp2ILInjected.Token(Token = "0x400060B")]
		RGBA_ASTC10X10_UFloat,
		// Token: 0x040005BD RID: 1469
		[global::Cpp2ILInjected.Token(Token = "0x400060C")]
		RGBA_ASTC12X12_UFloat
	}
}
