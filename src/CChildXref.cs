/* CChildXref.cs
 * 
 * Copyright 2009 Alexander Curtis <alex@logicmill.com>
 * This file is part of GEDmill - A family history website creator
 * 
 * GEDmill is free software: you can redistribute it and/or modify
 * it under the terms of the GNU General Public License as published by
 * the Free Software Foundation, either version 3 of the License, or
 * (at your option) any later version.
 *
 * GEDmill is distributed in the hope that it will be useful,
 * but WITHOUT ANY WARRANTY; without even the implied warranty of
 * MERCHANTABILITY or FITNESS FOR A PARTICULAR PURPOSE.  See the
 * GNU General Public License for more details.
 *
 * You should have received a copy of the GNU General Public License
 * along with GEDmill.  If not, see <http://www.gnu.org/licenses/>.
 *
 *
 * History:  
 * 10Dec08 AlexC          Migrated from GEDmill 1.10
 *
 */

using System;

namespace GEDmill.LLClasses
{
    // Data structure that holds the reference to a irSibling in a fr record, 
    // together with it's position in the file, which is important for sorting 
    // children with unknown birth dates.
    public class CChildXref
    {
        // Numerical ordering of this entry in the GEDCOM file
        public int m_nPositionInFile;

        // The xref itself
        public string m_xref;

        // Constructor
        public CChildXref( int nPositionInFile, string xref )
        {
            m_nPositionInFile = nPositionInFile;
            m_xref = xref;
        }
    }
}
