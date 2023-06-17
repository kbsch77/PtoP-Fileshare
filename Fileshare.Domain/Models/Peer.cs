﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.PeerToPeer;
using System.Text;
using System.Threading.Tasks;

namespace Fileshare.Domain.Models
{
    internal class Peer<T>
    {
        public string Username { get; set; }
        public PeerName PeerName { get; set; }
        public T Channel { get; set; }
        public T Host { get; set; }

    }
    public class PeerEndPointCollection
    {
        public PeerEndPointCollection(PeerName peer, IPEndPoint ipEndPoint) 
        {
            PeerHostName = peer;
            PeerEndPoint = ipEndPoint;
        }

        public PeerName PeerHostName { get; }
        public IPEndPoint PeerEndPoint { get;}
    }
}
