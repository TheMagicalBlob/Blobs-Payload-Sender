#if DEBUG
#endif

namespace PayloadSender
{
    internal partial class Payload_Sender
    {
        //! TODO: Convert these to hexadecimal
        // Just the function array pointer at the start of each dmenu struct read as an unsigned 64bit integer
        enum dmenu_type_ids : ulong
        {
            dmenu_id_menu_base = 0x322E688,

            dmenu_id_menu = 0x322E5B0,
            dmenu_id_dyn_menu = 0x31B5248, // slightly larger than normal menus, I think these are ones generated when opened. //! check when headache gone
            dmenu_id_unk_menu = 0x32280B0,

            dmenu_id_submenu_item = 0x322E488,
            dmenu_id_task_submenu_item = 0x3252D58,
            dmenu_id_noreturn_task_submenu_item = 0x3252C30,

            dmenu_id_bool_item = 0x322DA18,
            dmenu_id_exec_item = 0x322E238,
            dmenu_id_alt_exec_item = 0x322E360,
            dmenu_id_string_item = 0x322DFE8,
            dmenu_id_string_list_item = 0x322DC68,
            dmenu_id_float_item = 0x322E110,
            dmenu_id_decimal_item = 52616888,
            dmenu_id_separator_item = 52614816,
            dmenu_id_task_history_item = 52767200,
            dmenu_id_task_item = 52767496,
            dmenu_id_user_item = 52706288, // Entirely useless, maybe it's meant to be replaced by an actual user name? idk
            dmenu_id_timer_item = 51476832,
            dmenu_id_unk_item = 52616000

        }
    }
}