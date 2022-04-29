﻿/* TODO list:
 * Non-seed input ports for Matryoshka
 * Optimize ChunkRenderer for #vert batched readback
 * Animals
 * LOD
 * Optimized mesh generation on HOST
 * Elements / Block updates
 * Block Entities (extra block info) / FileFormat etc.
 * CPP plugin ?
 * 
 * [DONE] Switch blocks from uint into structs
 * [DONE] BlockGroups
 * [DONE] Load from MagicaVoxel
 * [DONE] Fine Structure 16
 */

/* ISSUES:
 * BlockRegistryTable not saving the asset correctly, texture atlas lost when reopen project
 */

/* Profiling @ 2021-02-26, After switch from uint to ushort + ushort (Block)
 * Main bottleneck IS World Generation:
 *  CustomJob could be improved via pooling (Is LinkedList the best solution ?)
 *  GeometryIndependentPass (CustomJob) should be pooled
 *  DON'T rebuild Matryoshka Graph everytime a StructureGenerator is generated ...
 */

// https://docs.unity3d.com/ScriptReference/Build.IPreprocessBuildWithReport.OnPreprocessBuild.html
