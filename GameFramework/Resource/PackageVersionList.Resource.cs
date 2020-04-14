﻿//------------------------------------------------------------
// Game Framework
// Copyright © 2013-2020 Jiang Yin. All rights reserved.
// Homepage: https://gameframework.cn/
// Feedback: mailto:ellan@gameframework.cn
//------------------------------------------------------------

namespace GameFramework.Resource
{
    public partial struct PackageVersionList
    {
        /// <summary>
        /// 普通资源。
        /// </summary>
        public struct Resource
        {
            private static readonly int[] EmptyIntArray = new int[] { };

            private readonly string m_Name;
            private readonly string m_Variant;
            private readonly byte m_LoadType;
            private readonly int m_Length;
            private readonly int m_HashCode;
            private readonly int[] m_AssetIndexes;

            /// <summary>
            /// 初始化普通资源的新实例。
            /// </summary>
            /// <param name="name">普通资源名称。</param>
            /// <param name="variant">普通资源变体名称。</param>
            /// <param name="loadType">普通资源加载方式。</param>
            /// <param name="length">普通资源长度。</param>
            /// <param name="hashCode">普通资源哈希值。</param>
            /// <param name="assetIndexes">普通资源包含的资产索引集合。</param>
            public Resource(string name, string variant, byte loadType, int length, int hashCode, int[] assetIndexes)
            {
                if (string.IsNullOrEmpty(name))
                {
                    throw new GameFrameworkException("Name is invalid.");
                }

                m_Name = name;
                m_Variant = variant;
                m_LoadType = loadType;
                m_Length = length;
                m_HashCode = hashCode;
                m_AssetIndexes = assetIndexes ?? EmptyIntArray;
            }

            /// <summary>
            /// 获取普通资源名称。
            /// </summary>
            public string Name
            {
                get
                {
                    return m_Name;
                }
            }

            /// <summary>
            /// 获取普通资源变体名称。
            /// </summary>
            public string Variant
            {
                get
                {
                    return m_Variant;
                }
            }

            /// <summary>
            /// 获取普通资源加载方式。
            /// </summary>
            public byte LoadType
            {
                get
                {
                    return m_LoadType;
                }
            }

            /// <summary>
            /// 获取普通资源长度。
            /// </summary>
            public int Length
            {
                get
                {
                    return m_Length;
                }
            }

            /// <summary>
            /// 获取普通资源哈希值。
            /// </summary>
            public int HashCode
            {
                get
                {
                    return m_HashCode;
                }
            }

            /// <summary>
            /// 获取普通资源包含的资产索引集合。
            /// </summary>
            /// <returns></returns>
            public int[] GetAssetIndexes()
            {
                return m_AssetIndexes;
            }
        }
    }
}