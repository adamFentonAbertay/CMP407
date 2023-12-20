/////////////////////////////////////////////////////////////////////////////////////////////////////
//
// Audiokinetic Wwise generated include file. Do not edit.
//
/////////////////////////////////////////////////////////////////////////////////////////////////////

#ifndef __WWISE_IDS_H__
#define __WWISE_IDS_H__

#include <AK/SoundEngine/Common/AkTypes.h>

namespace AK
{
    namespace EVENTS
    {
        static const AkUniqueID PLAY_LAVA = 4151061776U;
        static const AkUniqueID PLAY_MUSICSWITCHMAIN = 1435236U;
        static const AkUniqueID PLAY_PLAYER_FOOTSTEP_01 = 603342096U;
        static const AkUniqueID PLAY_SFXBUDDYROLLING = 3541750672U;
        static const AkUniqueID STOP_SFXBUDDYROLLING = 3691610534U;
    } // namespace EVENTS

    namespace STATES
    {
        namespace PLAYERBIOME
        {
            static const AkUniqueID GROUP = 3510927050U;

            namespace STATE
            {
                static const AkUniqueID NORMAL = 1160234136U;
                static const AkUniqueID SAND = 803837735U;
                static const AkUniqueID SNOW = 787898836U;
            } // namespace STATE
        } // namespace PLAYERBIOME

        namespace PLAYERHEALTHSTATE
        {
            static const AkUniqueID GROUP = 2698781627U;

            namespace STATE
            {
                static const AkUniqueID HIGHHEALTH = 3354037799U;
                static const AkUniqueID LOWHEALTH = 1017222595U;
                static const AkUniqueID NONE = 748895195U;
            } // namespace STATE
        } // namespace PLAYERHEALTHSTATE

    } // namespace STATES

    namespace GAME_PARAMETERS
    {
        static const AkUniqueID COMBATLEVEL = 3717892141U;
        static const AkUniqueID PLAYERHEALTH = 151362964U;
        static const AkUniqueID WATERLEVEL = 2616787940U;
        static const AkUniqueID WATERLEVELBUDDY = 1521967908U;
    } // namespace GAME_PARAMETERS

    namespace TRIGGERS
    {
        static const AkUniqueID ONLAVA = 2380591324U;
    } // namespace TRIGGERS

    namespace BANKS
    {
        static const AkUniqueID INIT = 1355168291U;
        static const AkUniqueID SFXSOUNDBACK = 3725668522U;
    } // namespace BANKS

    namespace BUSSES
    {
        static const AkUniqueID MASTER_AUDIO_BUS = 3803692087U;
        static const AkUniqueID REVERBS = 3545700988U;
    } // namespace BUSSES

    namespace AUX_BUSSES
    {
        static const AkUniqueID ROOM1REVERB = 2192967153U;
        static const AkUniqueID ROOM2REVERB = 2460247990U;
    } // namespace AUX_BUSSES

    namespace AUDIO_DEVICES
    {
        static const AkUniqueID NO_OUTPUT = 2317455096U;
        static const AkUniqueID SYSTEM = 3859886410U;
    } // namespace AUDIO_DEVICES

}// namespace AK

#endif // __WWISE_IDS_H__
