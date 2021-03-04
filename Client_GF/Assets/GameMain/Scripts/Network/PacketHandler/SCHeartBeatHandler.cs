﻿//------------------------------------------------------------
// Game Framework
// Copyright © 2013-2020 Jiang Yin. All rights reserved.
// Homepage: https://gameframework.cn/
// Feedback: mailto:ellan@gameframework.cn
//------------------------------------------------------------

using GameFramework.Network;
using UnityGameFramework.Runtime;

public class SCHeartBeatHandler : PacketHandlerBase {
    public override int Id {
        get {
            return 2;
        }
    }

    public override void Handle(object sender, Packet packet) {
        SCHeartBeat packetImpl = (SCHeartBeat)packet;
        Log.Info("Receive packet '{0}'.", packetImpl.Id.ToString());
    }
}
