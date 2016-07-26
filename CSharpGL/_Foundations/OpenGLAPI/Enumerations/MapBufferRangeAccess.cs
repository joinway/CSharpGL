﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;


namespace CSharpGL
{
    /// <summary>
    /// 
    /// </summary>
    [Flags]
    public enum MapBufferRangeAccess : uint
    {
        /// <summary>
        /// 
        /// </summary>
        MapReadBit = OpenGL.GL_MAP_READ_BIT,
        /// <summary>
        /// 
        /// </summary>
        MapWriteBit = OpenGL.GL_MAP_WRITE_BIT,
        /// <summary>
        /// 
        /// </summary>
        MapInvalidateRangeBit = OpenGL.GL_MAP_INVALIDATE_RANGE_BIT,
        /// <summary>
        /// 
        /// </summary>
        MapInvalidateBufferBit = OpenGL.GL_MAP_INVALIDATE_BUFFER_BIT,
        /// <summary>
        /// 
        /// </summary>
        MapFlushExplicitBit = OpenGL.GL_MAP_FLUSH_EXPLICIT_BIT,
        /// <summary>
        /// 
        /// </summary>
        MapUnsynchronizedBit = OpenGL.GL_MAP_UNSYNCHRONIZED_BIT,
        //MapPersistentBit = OpenGL.GL_MAP_PERSISTENT_BIT,
        //MapCoherentBit = OpenGL.GL_MAP_COHERENT_BIT,
    }
}