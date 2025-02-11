<template>
  <v-container fluid style="padding: 0;">
    <div id="background">
    </div>

    <div id="nav_global">
      <router-link to="/"><v-icon>mdi-chevron-left</v-icon><img src="../assets/images/icon.png" width="30" height="30" class="nav_global_icon"></router-link>
    </div>

    <div style="height: 60px;"></div>

    <div class="cont">
      <div class="date">
        2023-10-17 : Patch 1.0.2.4
      </div>
      <h4>Code</h4>

      <ul class="changelogitem">
        <li>Added FOV slider to the advanced video options, you can now set a FOV between 75 and 120.</li>
        <li>Bank will be opened directly if you have bank access.</li>
        <li>Fixed local player cache being reset in online mode, it will now load correctly.</li>
        <li>Quest list category states will now be saved in the local player cache (minimized / maximized state).</li>
        <li>Last quest shown in the quest list will also be saved in the local player cache.</li>
      </ul>
      </div>

    <div class="cont">
      <div class="date">
        2023-09-27 : Patch 1.0.2.3
      </div>
      <h4>Code</h4>

      <h5>Entities</h5>
      <ul class="changelogitem">
        <li>All player spawn point related entities are now server-only entities.</li>
        <li>Ensure that info_targets can be written to the path node data (will not be removed from the bsp!).</li>
        <li>Added an option to hide NPCs, items, etc from being written to the objective markers metadata file.</li>
      </ul>

      <h5>NPCs</h5>
      <ul class="changelogitem">
        <li>Assign higher threat to the first enemy engaged.</li>
        <li>Added swimming logic for NPCs that have the necessary anims.</li>
        <li>Fixed Giant spellcast anim T-pose.</li>
        <li>Added blacksmith work anims.</li>
      </ul>

      <h5>Players</h5>
      <ul class="changelogitem">
        <li>Added firstperson mode - WiP (no proper viewmodel yet).</li>
        <li>Added swimming anims & new swim move mechanics.</li>
        <li>Added new mount (horse) anims & mount move mechanics.</li>
        <li>Added better player data validation - ensure that you fetch new player data on reconnect, and on server restart.</li>
        <li>Fixed character selection keypress sensitivity - prevent accidental disconnection.</li>
        <li>Fixed detail dist override convar in the advanced options, it now works as intended.</li>
        <li>Improved quest system to allow arbitrary item types, rather than quest items only. Also ensured that we only remove the requried quantity for target items, and that they actually are in your inventory!</li>
        <li>Item deletion will now delete the entire stack by default. You may use the GUI action key to open the prompt to specifcy the exact amount to delete, if you wish to delete less.</li>
        <li>Fixed a bug which would prevent model particles from being re-created when you unequipped an item and equipped it again - ensure to set a dummy model when nothing is equipped.</li>
      </ul>

      <h5>GUI & HUD</h5>
      <ul class="changelogitem">
        <li>Added main-menu blur when in-game.</li>
        <li>Minor adjustments to label positions in the merchant items, quest rewards, etc.</li>
        <li>HUD messages should display properly on ultra-wide resolutions.</li>
      </ul>

      <h4>Balancing & Item Data</h4>
      <ul class="changelogitem">
        <li>Added quests to exchange the cloak you picked in the 'Purging the Tormented' quest for another.</li>
        <li>Added two new quests from the Smuggler's Guild.</li>
        <li>Added a new quest from the Chantry.</li>
        <li>Rebels map markers will now be hidden to prevent confusion.</li>
        <li>Adjusted max rare rewards dropped from Moroes.</li>
        <li>Adjusted max rare rewards dropped from Forgotten Guardian.</li>
        <li>Adjusted max rare rewards dropped from Mol'Baragh.</li>
        <li>Adjusted rare loot drop chances for the starting bandits.</li>
      </ul>

      <h4>Misc</h4>
      <ul class="changelogitem">
        <li>Added more achievements!</li>
        <li>Fixed Mol'Baragh safespot exploit.</li>
        <li>Adjusted the drop chance RNG logic.</li>
        <li>Optimized NAV mesh further - no need for extensive visibility checks.</li>
      </ul>
      </div>

    <div class="cont">
      <div class="date">
        2023-03-21 : Patch 1.0.2.2
      </div>
      <h4>Code</h4>

      <h5>Entities</h5>
      <ul class="changelogitem">
        <li>path_track and path_corner can now be set to write directly to the map metadata file, thus we save entity edicts. You can now basically have unlimited path nodes for your NPCs!</li>
        <li>Added func_night_scale, use this to adjust the night color correction when entering buildings, caves, etc.</li>
        <li>Added sky dome support.</li>
        <li>Added sky dome properties to env_night_cycle, the sky dome is automatically injected into the 3D skybox.</li>
        <li>Added func_detail_blocker.</li>
      </ul>

      <h5>NPCs</h5>
      <ul class="changelogitem">
        <li>Quest NPC interaction will affect everyone in your group.</li>
        <li>Static NPCs will now fade out and in during respawn cycles.</li>
        <li>Static NPCs will no longer have glow active if disabled.</li>
      </ul>

      <h5>Players</h5>
      <ul class="changelogitem">
        <li>Taunt is now a gesture, no more full body anim.</li>
        <li>Reloading crossbows will now slow you down by roughly 40%.</li>
        <li>Block & Attack timers will be properly cleared when you mount or unmount.</li>
        <li>Your name must now be at least 2 characters long in online mode.</li>
        <li>Added an auto run key, bind it in the options to use it!</li>
      </ul>

      <h5>GUI & HUD</h5>
      <ul class="changelogitem">
        <li>Updated the cooldown texture.</li>
        <li>Updated the quest reward selection texture.</li>
        <li>Items that you cannot buy from a merchant will have their price rendered in red.</li>
        <li>Quest markers and icons will be properly refreshed when retrieving local player data.</li>
      </ul>

      <h4>Balancing & Item Data</h4>
      <ul class="changelogitem">
        <li>Liberate the Slaves will progress for everyone in your group.</li>
        <li>Nerfed Moroes's Shadow Circle slightly.</li>
        <li>Buffed Arcane Bolt explosion radius by 15 units.</li>
        <li>Wolves at the gate II & III can now be picked up at any level - assuming you completed the first one in the chain.</li>
        <li>Adjusted Purge the Filth quest level range.</li>
        <li>Adjusted Vicious Rebels quest level range.</li>
        <li>Adjust Chicken Escape! quest level range.</li>
        <li>Adjusted Bandit Alpha LvL from 20 to 16.</li>
        <li>Adjusted Bandit Alpha Damage Scale from 3.25 to 2.50.</li>
        <li>Adjusted Bandit Ranger Damage Scale from 4.15 to 3.00.</li>
        <li>Adjusted Bandit Legionnaire LvL from 15 to 14.</li>
        <li>Adjusted Bandit Legionnaire Damage Scale from 2.50 to 2.00.</li>
        <li>Adjusted Creeping Lurker LvL from 16 to 14.</li>
        <li>Adjusted Creeping Matriarch LvL from 24 to 18.</li>
        <li>Adjusted Creeping Matriarch Damage.</li>
        <li>Adjusted Wolf Lite LvL from 15 to 10.</li>
        <li>Adjusted Wolf Alpha LvL from 18 to 14.</li>
      </ul>

      <h4>Map Compile Tools</h4>
      <ul class="changelogitem">
        <li>Propper bound brushes will be automatically compiled and injected by VBSP.</li>
        <li>Add support for compileNoShadows.</li>
        <li>Increased max thread count from 16 to 32.</li>
        <li>Increased max map entities from 8192 to 65536.</li>
        <li>Increased max map worldlights from 8192 to 65536.</li>
        <li>Increased max map overlays from 512 to 8192.</li>
      </ul>

      <h4>Misc</h4>
      <ul class="changelogitem">
        <li>Further networking and performance improvements!</li>
        <li>Reloading the game data will no longer respawn players, nor potentially bug NPCs state.</li>
        <li>Fixed helm01 and helm03 glitchy bonemerge.</li>
        <li>Added prop detail distance draw slider to the advanced options panel.</li>
        <li>Adjusted detail prop sway cvars.</li>
        <li>Updated Russian translations.</li>
      </ul>
      </div>

    <div class="cont">
      <div class="date">
        2023-01-20 : Patch 1.0.1.9 - 1.0.2.1
      </div>
      <h4>Code</h4>

      <ul class="changelogitem">
              <li>Added Steam Workshop!</li>
        <li>Added Steam Rich Presence.</li>
        <li>Improved Discord Rich Presence.</li>
        <li>AoE healing / damage should not affect dead NPCs & Players.</li>
        <li>Improved IDLE spell casting animations for NPCs.</li>
        <li>Improved ranged and spell (magic) projectile hit detection!</li>
        <li>Improved local player cache hash algorithm.</li>
        <li>Main-Menu will now display total amount of active players.</li>
        <li>character_import can now be used with an optional name argument, if empty, current name will be chosen.</li>
        <li>Fixed loading tip translation issues.</li>
      </ul>

      <h4>Balancing & Item Data</h4>
      <ul class="changelogitem">
              <li>Added a new sword drop from Bandit Alpha.</li>
        <li>Added a new ranged spell 'Explosive Shot'.</li>
        <li>Arcane Bolt now explodes on impact, damaging nearby enemies within a radius of 60 units.</li>
        <li>Reduced Arcane Bolt damage by roughly 15%.</li>
        <li>Reduced Impale cooldown from 15 to 10 sec.</li>
        <li>Reduced Fiery Arrow cooldown from 12.5 to 2.5 sec.</li>
        <li>Removed -5 intellect stat from Doomhammer.</li>
        <li>Added +10 Ranged Attack Power and +10 Focus to Death's Mercy.</li>
        <li>Added +30 armor and some more stamina to Ring of Protection.</li>
        <li>Increased stamina, intellect and spell power for Moroes's Signet Ring.</li>
        <li>Added +10 focus to Moroes's Signet Ring.</li>
        <li>Removed negative stats on Moroes's Signet Ring.</li>
        <li>Increased intellect, spell power and focus for Necklace of Necromancy.</li>
      </ul>
      </div>

    <div class="cont">
      <div class="date">
        2023-01-07 : Patch 1.0.1.7 - 1.0.1.8
      </div>
      <h4>Code</h4>

      <h5>Players</h5>
      <ul class="changelogitem">
              <li>Added 29 Steam Achievements!</li>
      </ul>

      <h4>Balancing & Item Data</h4>
      <ul class="changelogitem">
              <li>Reduced focus cost for all ranged spells.</li>
      </ul>
      </div>

    <div class="cont">
      <div class="date">
        2022-12-12 : Patch 1.0.1.6
      </div>
      <h4>Code</h4>

          <h5>Master Server</h5>
          <ul class="changelogitem">
              <li>Migrated to SQLite3 as the default database choice, MySQL can still be used, but will require additional configuration. With SQLite3 there is no need for any dedicated SQL server, hosting your own online server will be much easier.</li>
        <li>Improved database efficiency - merged characters, players and equipinfo into a single table.</li>
        <li>Improved scalability - database will no longer be used on the gameservers at all, selected characters are requested and kept in memory throughout the server's lifespan.</li>
        <li>Added integrated SQL backup scheduling.</li>
          </ul>

      <h5>Entities</h5>
      <ul class="changelogitem">
              <li>Projectiles can no longer be body blocked by allies.</li>
        <li>Projectiles will no longer get blocked by func_buttons.</li>
        <li>Improved +use traces, picking up objective items should be easier.</li>
        <li>Fixed color_correction and color_correction_volume.</li>
        <li>Removed duped outputs and inputs due to bad FGD inheritance hierarchy.</li>
        <li>Added a simple night cycle system.</li>
        <li>Fixed footstep sounds - they should no longer only play for the left pane when using headphones.</li>
        <li>Fixed projectiles impact particle effect - they were not showing because they were parented to the projectile, thus they were removed as the projectile triggered any impact..</li>
        <li>NPC auto spawner will now keep track of render mode, render fx and render color, and it will transmit these variables to the associated corpse.</li>
        <li>Added logic_bernoulli - can be used to trigger rare events with a better RNG.</li>
      </ul>

      <h5>NPCs</h5>
      <ul class="changelogitem">
              <li>Added proper head YAW/Pitch blend anims to the Giant.</li>
        <li>Added spellcast anims to most humanoid models.</li>
        <li>Added PrintDialogueParty - use this to print dialogue to a single player or that player's party.</li>
        <li>Added support for entirely particle based NPCs.</li>
        <li>Monster based NPCs can now cast spells properly.</li>
        <li>Added OnReachedSpawn output.</li>
        <li>Combatant & Monster NPCs now share similar soundscript prefix, to prevent issues if you set the same NPC ID for a monster and combatant NPC.</li>
        <li>Added idle activity override.</li>
        <li>Monster NPCs can now use ACT_IDLE_ANGRY as an engagement idle anim when in combat.</li>
        <li>If an NPC tries to heal itself or someone else - do not alter its angles.</li>
      </ul>

      <h5>Players</h5>
      <ul class="changelogitem">
              <li>Casting spells will reset the AFK timer.</li>
        <li>Botting with +attack will no longer reset the AFK timer.</li>
        <li>You will now lose 2.5% of your coins if you die in the world (if you have more than 500 coins in your inventory), instead of 10%.</li>
        <li>You will now lose 5% of your coins if you die in a dungeon (if you have more than 500 coins in your inventory), instead of 10%.</li>
        <li>Removed level requirements from dungeons.</li>
        <li>Dungeons now support up to 10 players instead of just 5.</li>
        <li>Weapons & Armor particles will stop emission when leaving PVS.</li>
        <li>Added spellcast anims.</li>
        <li>You can now import your current character for co-op and offline play by writing character_import in the console (not usable on co-op server).</li>
      </ul>

      <h5>GUI & HUD</h5>
      <ul class="changelogitem">
        <li>Improved 4K support - no more stretchy & bloaty!</li>
              <li>Use upper-case abbreviations for key bindings on action slots.</li>
        <li>Improved loading screen layout.</li>
        <li>Removed useless compression on many textures - no more blurry shite when using larger resolutions.</li>
        <li>Updated group interface to be more compact and less intrusive to your precious pixels.</li>
        <li>World map will now show which quests a quest giver can give you, and which quests can be handed-in.</li>
        <li>You can now double click a quest to toggle tracking for that quest.</li>
        <li>You can now press ENTER to trigger the accept button in the notification panel, when you try to add a friend, add someone to your guild, etc.</li>
        <li>Updated quest exclamation and question mark icon animation to be more visible.</li>
        <li>Capitalized keybinds in the keybind bar.</li>
        <li>You can now see which spells your target is casting.</li>
        <li>Fixed slow scroll speed in the quest list interface.</li>
        <li>Added death hint.</li>
        <li>3D player title text (nameplate) will render in green if that player is in your group (makes it easier to distinguish your friends).</li>
      </ul>

      <h5>Combat</h5>
      <ul class="changelogitem">
              <li>Added ammo capacity to Crossbows.</li>
        <li>Improved hit detection with melee, magic & ranged, especially for particle NPCs and smaller NPCs like rats & spiders.</li>
      </ul>

          <h4>Maps</h4>
          <ul class="changelogitem">
              <li>
          <b>Cavern of Torment</b>
                  <ul class="changelogitem">
                      <li>Added a new dungeon!</li>
                  </ul>
              </li>
              <li>
                  <b>Lightfall</b>
                  <ul class="changelogitem">
                      <li>Removed some god spots.</li>
            <li>Clipped chalice near the blacksmith.</li>
            <li>Fixed some bad NAV areas in the cave.</li>
            <li>Added some more details to the docks area in the city.</li>
            <li>Added entrance area to the new dungeon.</li>
            <li>Simplified invasion event, it will be triggered at 10am, 5pm and 10pm.</li>
                  </ul>
              </li>
          </ul>

      <h4>Balancing & Item Data</h4>
      <ul class="changelogitem">
              <li>Blackhand will no longer do significant extra damage.</li>
        <li>Steam Crossbow now has a magazine of 5 projectiles.</li>
        <li>Crushing blow will now ignore 25% of the opponents armor.</li>
        <li>Added a spell which toggles a dynamic light around the player (client-side), lasts until death.</li>
        <li>Added missing magic type to Arcane Bolt.</li>
        <li>Added Fire Blast spell - Instant Magic attack.</li>
        <li>Added Piercing Shot - Ranged attack which ignores 100% armor.</li>
        <li>Added Paralyze - Ranged attack which slows opponent by 50%.</li>
        <li>Added more junk loot drops from wolves, spiders and bandits.</li>
        <li>Moroes will cast Shadow Circle faster.</li>
        <li>Changed Steam Crossbow attack speed from 1.75 to 2.00 default.</li>
        <li>Changed Shadow Circle focus cost from 65 to 50.</li>
        <li>Changed Fireball focus cost from 35 to 30.</li>
        <li>Changed Frostbolt focus cost from 40 to 30.</li>
      </ul>

      <h4>Item Creator</h4>
      <ul class="changelogitem">
              <li>Add 2D preview icon support for NPCs.</li>
        <li>Add hitbox bounds for NPCs.</li>
      </ul>

      <h4>Misc</h4>
      <ul class="changelogitem">
        <li>Added <b>singleplayer and co-op</b> support! In this mode you simply upload your client-side character to the server you play on. Map changes will be based on a votemap prompt. Servers have to be started with the -coop argument to initialize as co-op!</li>
              <li>Removed the embedded MySQL tools from the dedicated server, if you still wish to use MySQL you will have to setup your own database.</li>
      </ul>
      </div>

    <div class="cont">
      <div class="date">
        2021-06-26 : Patch 1.0.1.5
      </div>
      <h4>Code</h4>

      <h5>Entities</h5>
      <ul class="changelogitem">
              <li>Fixed a crash which would happen if a player or npc had more than one debuff and died from the first debuff.</li>
      </ul>

      <h5>Players & NPCs</h5>
      <ul class="changelogitem">
              <li>Added sound when opening the bank.</li>
        <li>Added sound when selling and buying items.</li>
        <li>Added sound when sending or receiving private messages.</li>
        <li>Added sound when triggering chance on hit, and damage debuffs.</li>
        <li>Added sound when you reach min or max rep of a certain faction.</li>
        <li>Added friend online and offline sound.</li>
        <li>Added Level Up sound.</li>
        <li>Added sound when consuming food.</li>
        <li>Added sound when consuming potions.</li>
      </ul>

      <h4>Balancing & Item Data</h4>
      <ul class="changelogitem">
              <li>Abomination no longer gives any XP.</li>
        <li>Abomination will give 200 coins instead of 250.</li>
        <li>Fixed attack speed for all ranged NPCs, rebel, bandit ranger will fire slower, and also skeletal rangers.</li>
      </ul>

      <h4>Misc</h4>
      <ul class="changelogitem">
              <li>Fixed potential freezing due to probabilistic while loops.</li>
        <li>Added portuguese translation, creds to Dejoota.</li>
        <li>Added new sfx and giant sounds, creds to Dejoota.</li>
      </ul>
      </div>

    <div class="cont">
      <div class="date">
        2021-05-15 : Patch 1.0.1.4
      </div>
      <h4>Code</h4>

      <h5>NPCs</h5>
      <ul class="changelogitem">
              <li>Added disable movement option, useful for pure ranged NPCs that should only do target acquisition.</li>
              <li>Fixed fautly run anim being used when NPCs returned to spawn.</li>
              <li>Spell casting anims should be less glitchy.</li>
        <li>Improved Spellcaster AI.</li>
              <li>Improved movement blending code, legs will not glitch out anymore.</li>
              <li>If engaged, only look towards engaged target.</li>
              <li>Fixed bullseye NPCs, other NPCs can now engage with bullseyes on training dummies for example.</li>
              <li>Fleeing NPCs will not try to attack you, and will no longer potentially face you.</li>
              <li>Added missing properties to the auto respawn logic, such as disable movement, notify all squad members, damage filter, etc.</li>
              <li>Added relationship table, this is useful for future maps. For example if killing an NPC should increase rep with certain factions and decrease rep with opposing factions.</li>
              <li>No more focus regen while casting spells.</li>
              <li>Added bodygroup min and max, to allow further randomization on spawn.</li>
              <li>Added npc_snipe_dist for NPCs with disabled movement, this defines their range.</li>
              <li>NPCs will switch weapons less frequently, if they have three weapons available.</li>
              <li>Fixed ranged NPC movement logic, they will no longer move a lot back and forth when they try to re-position for better aim.</li>
              <li>Spells now have ranks, higher rank spell does more damage.</li>
      </ul>

      <h5>Entities</h5>
      <ul class="changelogitem">
              <li>Added collision support for prop_dynamic_simple.</li>
              <li>Updated damagetype values in FGD for trigger_hurt, filter_damage_type and point_hurt.</li>
              <li>Added support for simple anims with prop_dynamic, will only trigger on the first sequence in the model however.</li>
              <li>Static NPCs no longer need a greetings anim.</li>
              <li>Static NPCs now have a list of animation types it can run while idle.</li>
              <li>Do not do baseflex blinking and head movement stuff when dead.</li>
              <li>Disabled anims in model preview panel.</li>
              <li>Fixed slave door anim, anim will be reflected to slave. (door handle anim)</li>
              <li>Music is now entirely scripted through the soundscape files rather than in data/base/music.</li>
              <li>Players & NPCs will now network HP and Focus regen changes less frequently to save net traffic. (accumulates up a certain amount before sending it to the players in PVS)</li>
              <li>logic_player_checker can now be instructed to remove an item it found, if successful.</li>
              <li>trigger_area_info now uses flags so that multiple conditions can be set for the same volume.</li>
              <li>Added PrintDialogueSingle to logic_npc_dialogue which will print dialogue for the activator only.</li>
              <li>Updated quest state logic for logic_player_checker, func_player_blocker, and NPCs. You can restrict interaction based on whether or not a quest is handed in, started, etc.</li>
              <li>Magic projectiles will not render any model, it is purely particle based.</li>
      </ul>

      <h5>Players</h5>
      <ul class="changelogitem">
              <li>Extended potion system, you can now buy potions that boost your stats. The potions are locked to certain "slots" meaning that you cannot stack them. A lesser Agility Potion will not stack with a stronger Agility Potion for example. There is also a designated potion slot for potions that boost multiple stats. These potions will last for a few minutes, and will not be removed on death or level changes! You can also find and use these pots in the quick selection HUD.</li>
              <li>Updated run and idle anims when no weapon is active.</li>
        <li>Fixed animstate issues (incorrect anims) when wielding a shield and one-handed weapon.</li>
              <li>Enabled dual wielding.</li>
              <li>Enabled bank system. You can also deposit and withdraw money from your bank!</li>
              <li>Fixed multiple prediction issues, these fixes resolves the glitchy jump lag players have experienced in the prior patches!</li>
              <li>Improved movement blending code, legs will not glitch out anymore.</li>
              <li>Added a few new face skins.</li>
              <li>Improved death anim.</li>
              <li>Fixed eye angles interpolation for other players, no more jittery angles.</li>
              <li>Updated idle anim for the model preview panel.</li>
              <li>Fixed a bug which would make you stuck in combat, if you had a debuff from some NPC, the debuff would trigger you in combat even after the target NPC left combat.</li>
              <li>Fixed a bug which prevented quests from sending rep data if the reward value was 0, which means affiliate.</li>
              <li>Other players will now broadcast their zone with userinfo updates.</li>
              <li>Fixed potential faulty userinfo and group data when adding group members that already existed in your party.</li>
              <li>Players will no longer be rendered in the wrong zone, if you are in a different zone.</li>
              <li>Reduced shared spell cooldown in order to make the spell system more useful. Chain triggering various spells is now slightly easier.</li>
              <li>Added rank system for spells, this will reduce clutter in the spell book. New rank spells can define new properties for the spell. But right now only the damages change.</li>
              <li>Added action spell presets, you can now save your action bar in four different presets. Double click the button for the desired preset to save the current action bar items, single click to switch to a preset.</li>
      </ul>

      <h5>GUI & HUD</h5>
      <ul class="changelogitem">
              <li>Items that require a higher level will render the required level in red.</li>
              <li>Active potion effects will be rendered next to the minimap.</li>
              <li>Replaced certain item types for armor, now there is only Light or Heavy armor.</li>
              <li>Added world map, use the left and right arrow to cycle between zones. The world map will display quest markers, objective markers, NPC markers, etc. Markers can be disabled, set to tracked or any quest through the options. You can zoom in and out with the mouse wheel, and by holding down Mouse1 you can pan the view.</li>
              <li>Closecaption will no longer use the vanilla HL2 HUD logic, it will only print to the chat with the respective NPC name. Similar to NPC dialogue, but triggers on sound files.</li>
              <li>Quests can now award multiple rep changes on completion.</li>
              <li>Fixed potential crash and invalid indexing in the quest tracker.</li>
              <li>You can now choose if you do not want the interaction panel to close when accepting a quest.</li>
              <li>Quest log will remember last opened quest.</li>
              <li>Added local player cache logic, this cache keeps track of tracked quests, and action presets.</li>
              <li>Health Potion, Focus Potion and Food will now auto generate the description.</li>
        <li>Fixed potential issues when changing the resolution, some GUI elements would not be recreated & updated.</li>
        <li>Added quest markers and quest objective markers to the minimap.</li>
      </ul>

      <h5>Combat</h5>
      <ul class="changelogitem">
              <li>You may only attack max 5 targets during a swing.</li>
              <li>Added knockdown attacks, this is a simple stun which lasts as long as the knockdown anim.</li>
              <li>Added blocking, a shield is twice as efficient, and can block up to three attacks. For players, strength determines how much base damage can be blocked.</li>
              <li>AoE spells can now trigger buff debuff logic, such as freezing everyone who got struck, or stunning them, etc.</li>
              <li>Crossbow reload will not be skipped on stun.</li>
              <li>Bow charging will be reset on stun.</li>
              <li>Fixed anim playback issues if you got knocked down or stunned while switching weapons, charging a bow or reloading.</li>
              <li>Chance on hit logic now supports restoring focus.</li>
              <li>Neutral NPCs can now actually deal damage...</li>
        <li>Fixed broken ranged spells, ranged spells now work for players and NPCs again.</li>
      </ul>

          <h4>Maps</h4>
          <ul class="changelogitem">
              <li>
          <b>Capital Outskirts</b>
                  <ul class="changelogitem">
                      <li>Slaves will now mine for minerals, added new mining anim.</li>
                      <li>Added lesser potion master in the city, moved potions from the brewmaster to this vendor.</li>
                      <li>Added more merchant variations.</li>
                  </ul>
              </li>
              <li>
          <b>Outskirts Catacombs</b>
                  <ul class="changelogitem">
                      <li>Added a new spawnable mini boss. Requires a quest!</li>
            <li>Changed the pit textures in Moroes's room.</li>
                  </ul>
              </li>
              <li>
                  <b>Lightfall</b>
                  <ul class="changelogitem">
                      <li>You can PvP in this map!</li>
                      <li>A new Smuggler's Guild faction, they got <b>goodies</b>.</li>
                      <li>Faction quartermasters, awesome gear!</li>
                      <li>17 new quests, a bunch of new items, and more!</li>
                  </ul>
              </li>
          </ul>

      <h4>Balancing & Item Data</h4>
      <ul class="changelogitem">
              <li>Reduced Focus Potion cooldown from 60 sec to 35 sec.</li>
              <li>Reduced Health Potion cooldown from 120 sec to 65 sec.</li>
              <li>Reduced Smuggler Lite damage by 5%.</li>
              <li>Reduced Elder Wolf damage by 2.5%.</li>
              <li>You now get 10 Chantry rep from every boss in the Catacombs.</li>
      </ul>

      <h4>Item Creator</h4>
      <ul class="changelogitem">
              <li>Fixed item damage type values.</li>
              <li>Fixed default layout size, 800x600.</li>
              <li>Fixed various issues in the tree node view for categories which only load from one file. Reduced the hierarchy to one node.</li>
              <li>Added reputation list for NPCs and Quests. For NPCs this define relationships, but also what rep is given to a player on kill. Quests can now award multiple rep changes.</li>
              <li>Removed music stuff, moved this logic to soundscapes entirely. Sound browser can still be used though.</li>
              <li>Fixed endless horizontal scrolling issues for some categories.</li>
              <li>Performance improvement when opening files, rendering files, layout, etc.</li>
              <li>Items are now shown as "Name (ID)" to prevent confusion if the items have same name.</li>
              <li>Greetings box will be hidden for merchants and bankers.</li>
      </ul>

      <h4>Misc</h4>
      <ul class="changelogitem">
              <li>Removed more legacy HL2 entities and logic.</li>
              <li>Minor performance and network improvements.</li>
              <li>Fixed lighting position issues on armor items.</li>
              <li>Updated VBSP and propper, VBSP can now generate map metadata which is used for quest marker logic. Propper can now generate more complex collision meshes.</li>
              <li>cl_leveloverview will enable firstperson cam when used, this will make it easier to position when creating minimap images.</li>
              <li>Renamed various files in the data/base folder to more reasonable names.</li>
              <li>nav_generate, nav_analyze, and nav_generate_incremental will remove various props before generation or analysis to prevent entities like doors from blocking the floodfil algorithm. Set nav_generate_remove_dynprops 1 to also remove any type of dynamic props.</li>
              <li>Added loading music when entering the game, and when transiting from one area to another.</li>
              <li>Updated dedicated server readme.</li>
      </ul>
      </div>

    <div class="cont">
      <div class="date">
        2020-07-16 : Patch 1.0.1.3
      </div>
      <h4>Code</h4>

      <h5>NPCs</h5>
      <ul class="changelogitem">
        <li>Static NPCs like merchants, quest givers, etc will now use more appropriate IDLE animations.</li>
        <li>Fixed a crash which would occur if the NPC tried to run a gesture with an invalid sequence ID. (missing animation)</li>
        <li>Fixed an issue which prevented NPCs from doing any damage when attacking with a shield.</li>
      </ul>

      <h5>Entities</h5>
      <ul class="changelogitem">
        <li>Soundscapes can now loop MP3 files properly.</li>
        <li>Removed unnecessary client interpolation variables related to animation stuff, all client anims for players, NPCs, etc... will now render much more smoothly!</li>
        <li>Chance on hit, damage over time and spell objects will no longer do any pushback when damaging targets.</li>
      </ul>

      <h5>Players</h5>
      <ul class="changelogitem">
        <li>Fixed a rare crash which occurred for some users when they selected a character.</li>
        <li>Fixed poseparameter issues when a player is mounted, the head yaw and pitch will now update properly and move/look in the right direction.</li>
        <li>Fixed animation walk cycles, other players will now walk in the correct directions, using the correct angles.</li>
        <li>Fixed bad interpolation on EyeAngles, which prevented certain poseparameters from being set correctly. Specifically aim YAW and PITCH were having issues, sometimes other players would not even update their aiming position due to bad interpolation.</li>
        <li>You can now trigger chance on hit properly when wielding a shield.</li>
        <li>Having negative armor will no longer give you a speed boost.</li>
      </ul>

      <h5>GUI & HUD</h5>
      <ul class="changelogitem">
        <li>Spell Cast Bar will now draw the targets name, if any target is required.</li>
        <li>Reduced the loading tips font size slightly.</li>
        <li>Combat Log will now use a more dynamic font size depending on whether or not the initial string would fit the bounds.</li>
        <li>Client ping is now reporting the correct value, in the main menu.</li>
      </ul>

      <h4>Balancing & Item Data</h4>
      <ul class="changelogitem">
        <li>Changed spell cast focus penalty to slow the regeneration rate dramatically for a small amount of time, rather than suspending regeneration entirely for a certain amount of time.</li>
        <li>Increased default run speed for NPCs from 170 to 210.</li>
        <li>Generic Food will now have a cooldown for 2.5 sec.</li>
        <li>Health Potions will have a cooldown for 120 sec.</li>
        <li>Focus Potions will have a cooldown for 60 sec.</li>
        <li>Cooldowns for food, health potions and focus potions are now shared for their respective sub types. Meaning that for example all health potions will now share the same cooldown.</li>
        <li>Smuggler Lite will now do 10% less damage.</li>
        <li>You may now trade tomes and super rare items.</li>
      </ul>

      <h4>Misc</h4>
      <ul class="changelogitem">
        <li>Fixed messy collision meshes for various props, especially foliage props. To prevent bad collision clipping.</li>
        <li>Removed unnecessary placeholder assets.</li>
        <li>Compressed some placeholder assets.</li>
        <li>Minor client performance improvements.</li>
        <li>Reloading client data will no longer break the spell action bar icons.</li>
        <li>Admins can no longer rename players to a name which contains non alphabetic characters.</li>
        <li>Updated Russian & German translations.</li>
      </ul>
      </div>

      <div class="cont">
          <div class="date">
              2020-06-16 : Patch 1.0.1.2
          </div>
          <h4>Code</h4>
          <h5>Master Server</h5>
          <ul class="changelogitem">
              <li>Guild names are now unique, meaning you can no longer create a guild with a name which already exists.</li>
              <li>Fixed admin rename command, you can no longer bypass profanity filter, and you cannot use whitespaces in the new name.</li>
              <li>You can no longer kick or ban other admins, as an admin.</li>
              <li>Added infestus_max_characters which allows the server admin to decide how many characters can be created per SteamID. Max is 12 for now, 5 is the default.</li>
          </ul>

          <h5>NPCs</h5>
          <ul class="changelogitem">
              <li>Fleeing NPCs will no longer look towards the enemy.</li>
              <li>NPCs that have an enemy, and are not busy in any way will always lock onto (look) their enemy.</li>
              <li>NPCs will start regenerating their health instantly after leaving combat, rather than only doing so when they arrive at their spawn point area.</li>
              <li>Nerfed pushback in the Z direction. No more flying NPCs when shield bashing.</li>
              <li>Fixed attack range issues for NPC monster.</li>
              <li>Stunning an NPC which is in the middle of a spellcast will not make the NPC stuck in spellcasting anims.</li>
              <li>Death anims are now finally smooth, no more jittery madness.</li>
              <li>Improved NPC AI and Squad LoS checks.</li>
              <li>If an NPC fail to return to its spawn at least 10 times, the NPC will be teleported to its spawn point.</li>
              <li>Added input to force the NPC to return to spawn, useful to prevent endless kiting in dungeons.</li>
              <li>Fixed missing Pain sound for combatant NPCs.</li>
              <li>Improved spellcast behavior for NPCs, instant spells are now triggered in a more feasible manner. And can be triggered while moving, no more movement blocking.</li>
              <li>Animation gestures are now properly synced between client & server.</li>
              <li>NPCs will sense more frequently when attacking other NPCs.</li>
              <li>Ranged NPCs will move back away from their foes, while shootin' them arrows. Rather than standing still like brainless monkeys.</li>
          </ul>

          <h5>Entities</h5>
          <ul class="changelogitem">
              <li>Arrows, Projectiles, Bubbles, Flares, etc... will now use low resolution origin to save performance.</li>
              <li>Fixed spell object rendering issues, spell objects like the healing circle would not render at certain camera angles. It would be culled.</li>
              <li>You can no longer stack spell objects in the Z direction.</li>
              <li>Increased bounding boxes for spell objects, especially the height. So that it will trigger touches a bit under its origin. Specifically if it was put on top of some stairs.</li>
              <li>Any model can now set IgniteModel in its KeyValues, so that it will light up forever. (particle) Useful for elemental style mobs.</li>
              <li>Spell objects will no longer flicker when they are rendering under water.</li>
              <li>prop_door_rotating, func_door and func_door_rotating will go fully non solid while moving an when opened to prevent NAV issues.</li>
              <li>prop_dynamic_simple, npc_static and mounted player models now have proper baseflex support, meaning they can blink, move their heads, etc.</li>
              <li>npc_static will now loop their idle anims properly.</li>
              <li>npc_static and item_object will have fade values set by default, using sv_items_fade_* and sv_npc_static_fade_*.</li>
              <li>Added distance culling for valid players and NPCs, this will remove said entities from being networked, processed and rendered if you are too far away from them. This is extremely helpful in large open maps where regular map optimization is not possible.</li>
              <li>Added filter_activator_npcid, which can be used to filter NPCs by their NPC ID.</li>
              <li>Doors can no longer be blocked by spell objects, npc static or corpses.</li>
              <li>Hidden item_objects or npc_statics will no longer accept +use inputs.</li>
              <li>Removed item_object_respawnable, respawning is now done internally in the item_object entity. This saves lots of entdata.</li>
              <li>item_chest will blink slowly to illuminate it in the dark.</li>
              <li>prop_dynamic can no longer do any animation related stuff, but can be used for large objects that can be moved around by for ex. a tracktrain. If animations are needed, use prop_dynamic_simple.</li>
          </ul>

          <h5>Players</h5>
          <ul class="changelogitem">
              <li>Armor and Weapons are now updated much faster on the client, when the player changes armor and weapons. (equipping)</li>
              <li>Hopefully fixed bugs related to floating armor for a brief amount of time when you enter the PVS of other players. Their armor could be floating around nearby the portal which changed the PVS state.</li>
              <li>Weapons and mounted player should now auto-scale according to the scaling used on the player itself.</li>
              <li>Reduced fall damage when mounted.</li>
              <li>You can no longer regenerate your health while taking continuous drown, acid, fall or poison damage.</li>
              <li>Removed pushback from drown, acid and fall damage.</li>
              <li>Removed all viewpunch related stuff.</li>
              <li>Drown damage will be inflicted every 0.5 sec rather than every 1.0 sec.</li>
              <li>You can no longer use the kill command in a lobby map.</li>
              <li>Fixed broken aiming for players, the crosshair is now accurate. For spells, melee, ranged, etc...</li>
              <li>Player glow effect color will change depending on your relationship towards the player, if the player glows red when you look at him you can attack him. If he glows green he is in your group, and brown means neutral.</li>
              <li>Death anim will no longer glitch out if you die while stunned.</li>
              <li>Camera will finally collide properly with prop door rotating and prop dynamic.</li>
              <li>Added proper client prediction, the prediction for the local player in Infestus has up until now been pretty much non existant. Prediction is very helpful for players with a high ping, because they do not have to wait for the server to confirm certain actions. Such as when you activate a spell, it will insta activate with similar logic for both client and server.</li>
              <li>Fixed weapons not being properly updated while dead.</li>
              <li>Fixed broken footstep timing, footsteps now sync up perfect for the local player and other players.</li>
          </ul>

          <h5>GUI & HUD</h5>
          <ul class="changelogitem">
              <li>Fixed faulty mount hint.</li>
              <li>You can now compare items in the player inspection panel.</li>
              <li>You will no longer open the player interaction panel while auto looting, whenever the special GUI action button is pressed.</li>
              <li>You can now set how far away 3D info text and health bars will render, infestus_3dinfo_distance.</li>
              <li>You can now set if you want to render 3D info for yourself, infestus_3dinfo_healthbars_local.</li>
              <li>Fixed 2D info not triggering at the correct position, it would start from the cameras actual position. Rather than the eye position, so if you zoomed far out you would potentially not draw any 2D info for the object you were looking at.</li>
              <li>Fixed +use not triggering when you zoom far out with the camera, due to the above mentioned fix for 2D info. The same problem would happen here as well.</li>
              <li>You can now invite players to join a group, guild, add friend, etc with mixed casing. Previously you had to write the exact name.</li>
              <li>Increased draw length for names in 2D and 3D info HUD.</li>
              <li>The header buttons in the Social Panel Search and Guild tab will no longer go invisible while pressed.</li>
              <li>Fixed centering for the player interaction panel.</li>
              <li>Fixed several issues related to binding problems with the Special GUI action key, if it was bound to multiple keys it would only trigger for one of them.</li>
              <li>You can now bind mouse buttons to the special GUI action key.</li>
              <li>Spells are now alphabetically sorted in the Spell Book Panel.</li>
              <li>Added Quick Mount Menu, which can be opened when pressing the dismount/mount key.</li>
              <li>Spell item tooltips will now specify the damage school of the spell, for ex if it does Fire damage rather than just regular damage.</li>
              <li>Spell item tooltips will now also specify the debuff or buff for the spell in question. For ex, if it will stun the target for X sec.</li>
              <li>Fixed quick item selection menu cooldown items rendering when you had 2 or less items, if you had a third item and it was on cooldown it would still render the cooldown for the non existant item. (missing reset)</li>
              <li>The ranged charge bar will now be properly reset when changing weapons and or mount.</li>
              <li>Combat icon will animate more intensly.</li>
              <li>Who List will no longer ignore your keywords if the keywords were longer than 32 bytes, the keywords will just be cropped.</li>
              <li>You can now search for guilds in the Who List, you can also see what guilds the players are in.</li>
              <li>Chance on Hit tooltips are now generated dynamically, in the item tooltip.</li>
              <li>Fixed 3D info pos for mounted players.</li>
              <li>Increased item tooltip default width.</li>
              <li>Changed item quantity font to a smaller font.</li>
              <li>Minimap will render more smoothly when it is not locked.</li>
          </ul>

          <h5>Weapons & Combat</h5>
          <ul class="changelogitem">
              <li>You no longer have to charge crossbows.</li>
              <li>You can now charge bows and keep it charged until you release the attack button, removed the depletion logic.</li>
              <li>Crossbows have to be reloaded. The reload speed depends on your Agility and initial attack speed.</li>
              <li>You may now charge bows faster depending on your Agility and on the weapons attack speed.</li>
              <li>Added proper impact sounds, when hitting flesh based targets.</li>
              <li>Melee weapons will now splash water if the melee attack traces through water.</li>
              <li>Improved melee hit detection further.</li>
              <li>Removed min and max range from the items, min and max range is now decided using different threshold values.</li>
          </ul>

          <h4>Maps</h4>
          <ul class="changelogitem">
              <li>Clipped fountain and barrels in Capital Outskirts.</li>
              <li>You can no longer kite bosses far away from their initial spawn points in dungeons.</li>
              <li>Anyone who falls into the pit in Outskirts Catacombs will heal Moroes.</li>
              <li>Moroes will reset critical value counter when leaving combat.</li>
          </ul>

          <h4>Balancing & Item Data</h4>
          <ul class="changelogitem">
              <li>Agility will now give increased mobility, 0.125% per point rather than 0.098% per point.</li>
              <li>Intellect will no longer give you super OP focus regeneration rates, the rate has been lowered from 1.5 to 0.105.</li>
              <li>Default focus regeneration rate has been changed from 1.75 to 2.00.</li>
              <li>Movement speed will be slowed down by 13.5% while charging bows.</li>
              <li>Removed item levels, item levels are computed automatically for the wiki items though. For sorting purposes.</li>
              <li>Vial of Demonic Rat Blood is no longer a RARE item.</li>
              <li>Cloth items will no longer give any armor!</li>
              <li>Increased the price for Healing Circle from 145 to 300.</li>
              <li>Increased the price for Crude Crossbow from 250 to 375.</li>
              <li>Nerfed rare loot drop percentages for non-bosses in Outskirts Catacombs.</li>
          </ul>

          <h4>Misc</h4>
          <ul class="changelogitem">
              <li>Added Russian translation provided by RedSkill.</li>
              <li>Added German translation provided by Huntereye.</li>
              <li>Added Simplified Chinese translation provided by SilverBob.</li>
              <li>Removed specular maps on bleed, frozen and fire material overlays.</li>
              <li>Released the dedicated server tools, feel free to give them a try! Host your own world!</li>
              <li>Nerfed the FGD files even more. Optimized a lot of client & server code. Removed more legacy stuff.</li>
              <li>Servers will now report the actual player count, but in the maps field.</li>
              <li>Fixed anims for all the current NPCs to use proper gestures! So that NPCs can attack while moving, and be more responsive in general.</li>
              <li>Testing locally is now more feasible as you can use spells properly, equip items, etc...</li>
              <li>Removed unused HL2 script files.</li>
          </ul>
      </div>

      <div class="cont">
          <div class="date">
              2019-12-29 : Patch 1.0.1.1
          </div>
      <h4>Code</h4>
      <h5>Master Server</h5>
      <ul class="changelogitem">
              <li>Simplified printing of debug messages.</li>
              <li>All data is now transferred in a more compact way, reducing packet size by roughly 3-4 times.</li>
              <li>Group data is no longer sent over on every spawn, lost data will be sent over using a queueing system which deals with storing data for players that are not available at the time.</li>
              <li>If you transit from one area to another, enter a dungeon or got disconnected for a short time but returned before being deemed offline, the master will queue all data that was meant for you. This data will be re-transmitted to you when you rejoin. Which means that lost private, guild, and group messages will always arrive! And other useful stuff.</li>
              <li>Regular updates are now being sent unreliably.</li>
              <li>When selecting a character or changing map, the world number will be clamped to make sure that you are not redirected to a dead world. If for some reason your character was tied to an old world number.</li>
              <li>You can no longer register non-existent GUIDs when connecting to the system, there was a minor bug here which would leave a client online in the system forever.</li>
              <li>You can now reconnect properly to the master server at any time, this fixed issues related to not being able to properly re-connect when you re-join a realm after a game crash. (it would work fine as long as you timedout on the server though)</li>
              <li>Added a simple profanity filter to prevent horrible player and guild names.</li>
              <li>Admins can now forcefully change someones name, if necessary.</li>
              <li>If you join a full dungeon you'll no longer be redirected for nothing.</li>
              <li>Events that can be handled directly on the game server without needing to wait for a callback form the master will now handle things directly. Which save bandwidth and increase consistency.</li>
              <li>Fixed a bug in the quest progression logic, if you removed an item which the quest had as a target objective it would potentially decrement its progress even if you had a greater quantity left. For example, you needed 5 stones, and you had 15. You remove 5 of those 15 stones and now the quest thinks you got no stones, but you got 10 stones left though!</li>
              <li>Optimized the memory usage of player and item data.</li>
              <li>Fixed issues related to the game server sending data to the master in the wrong order. This could lead to connection issues and worse.</li>
              <li>Player data can now be accessed faster, using regular PlayerID, Name hash or SteamID lookup.</li>
              <li>It is possible to add offline players to your friend list again.</li>
              <li>Improved the ban system to support proper IP banning.</li>
              <li>Added admin ban and kick commands.</li>
      </ul>

      <h5>NPCs</h5>
      <ul class="changelogitem">
              <li>Added full attack speed support for spells.</li>
              <li>Monster NPCs can now use the spell cast system more efficiently.</li>
              <li>Improved Monster NPCs melee combat logic, it is now harder to elude their attacks.</li>
              <li>NPCs will now update their facing angle much faster, when engaged by an enemy.</li>
              <li>Misc critters like birds will no longer spawn blood when hit.</li>
              <li>Added an option to disable HP regeneration in Hammer.</li>
          </ul>

          <h5>Entities</h5>
          <ul class="changelogitem">
              <li>Renamed trigger_pvp_zone to trigger_area_info, when a player enters this trigger it will enforce PvP, safe zone or auto-dismount for the player in question.</li>
              <li>Added logic_notification, which can be used to pop-up certain menus for interacting players.</li>
              <li>Fixed prop_door_rotating to always open away from the opener.</li>
              <li>item_object and other entities of interest may now blink when you are near them. This will be useful in dark maps, where the glow outline is not enough to help the player identify certain items.</li>
              <li>Fixed faulty bounding box for spell_object entities.</li>
              <li>You can no longer stack spell_objects on top of each other.</li>
              <li>func_fish_pool will now spawn client side fish entities. Which will save server performance and networking.</li>
              <li>Improved the loot system, when a corpse or chest is initialized its loots are shuffled internally from highest rarity to lowest rarity, a loop goes through the loots and checks whether or not loot X can be given. Starting with the rarest loot, this will ensure that we try to give the best loots when possible. I've also added a max rare reward number for corpses and chests, which will prevent a lootable object from dropping too many rare loots in one go.</li>
          </ul>

      <h5>Players</h5>
      <ul class="changelogitem">
              <li>Added mount support, when mounted you cannot attack, cast spells, or loot corpses/chests.</li>
              <li>Updated the item stat calculation to properly accumulate all stat values before applying the attack or spell power increase from certain stats, etc...</li>
              <li>Agility will now increase melee attack power by 0.25 per point.</li>
              <li>The correct skin and bodygroup flags are now being set for the player models, plus a new boolean value which determines gender has been added to ensure the right sounds.</li>
              <li>Added a fancy level-up particle.</li>
              <li>Animations will now update more smoothly when other players go from being in motion to standing still.</li>
              <li>Removed collision between players and NPCs.</li>
              <li>You can now auto-loot a corpse or chest by holding down special GUI action and then pressing E. (+use)</li>
              <li>You will now be fully frozen when connecting to a lobby.</li>
              <li>Projectiles will now go through friendlies when you are in a dungeon.</li>
              <li>Hopefully fixed a bug which prevented you from picking up and/or handing in finished quests.</li>
              <li>You will now regenerate HP and focus while casting spells. Focus will only regenerate with a rate of 15% though.</li>
              <li>Drawing and Holstering weapons will now use the correct animation delay time.</li>
              <li>Players in your group will now properly save new data so that they will not render faulty info when they leave your PVS.</li>
      </ul>

      <h5>GUI & HUD</h5>
      <ul class="changelogitem">
              <li>
                  Added a hint system which prints to the chat, I've tried to add hints for the most non obvious things in the game so far. A brief summary of the hints:
                  <ul>
                      <li>When opening the chat for the first time, display info about how to change chat channels and info about various chat commands.</li>
                      <li>When receiving a private message, notify the user that you can click R to initiate a quick reply.</li>
                      <li>When opening the character inventory panel, display info about the quick item selection, deleting items, and how to split/merge items.</li>
                      <li>When displaying an item tooltip, display info regarding the use of special GUI action key to compare equipped items with non-equipped ones of similar type.</li>
                      <li>When you try to finish a quest which requires you to select a reward, if no reward was selected print a hint about this.</li>
                      <li>When the loot roll panel, group invite or guild invite panel is up, hint that you need to hold down the special GUI action key to enable mouse input.</li>
                      <li>When the loot panel is opened, hint that you can auto-loot by holding the special GUI action key while pressing +use.</li>
                      <li>When joining a group, hint that you can leave the group by pressing G.</li>
                      <li>...</li>
                  </ul>
              </li>
              <li>Removed chat sounds for the player chatting channels. Chat notification sounds will only play for actual notifications and hints.</li>
              <li>Combat Log HUD will now fade properly when the associated convar value (infestus_combat_log_fade) is updated. When auto-fading out is enabled/disabled.</li>
              <li>Added notifications for successfully adding a friend, removing a friend/ignore or ignoring players.</li>
              <li>Overhauled the Social UI system.</li>
              <li>All inventory item icons are now higher-res.</li>
              <li>Searching for other players is no longer as cumbersome, the last search will be kept in memory. And you can sort the players on Name, Level and Zone.</li>
              <li>Fixed the Social UI searchbar to properly register the ENTER key.</li>
              <li>Added a guild tab to the Social system, here you can administrate your guild, see who's online, change the rank for members, etc...</li>
              <li>You now have to right click items in the guild or search Social UI tab in order to get a list of appropriate actions like Add Friend, Invite to Group, etc...</li>
              <li>Fixed a minor bug which would print friend notifications for the wrong player ID if you switched to another player directly through the console and then re-joining.</li>
              <li>Gave the reputation items a new fancy look in the character inventory panel.</li>
              <li>The stopwatch timer and spellbar will now render in the correct positions.</li>
              <li>You can now bind mouse keys to the special GUI action key. (+action)</li>
              <li>You can now zoom in and out of the minimap using the keypad '+'' and '-'' keys by default.</li>
              <li>Added a prompt when you try to leave a group, in case you accidentally hit the group leave key.</li>
              <li>You can now see which direction you're headed at in the minimap.</li>
              <li>Updated the zone name color code, it will now be all RED if you are flagged for PvP. Green otherwise, if you are safe.</li>
              <li>Finished quests will be drawn before unfinished quests, in the quest list UI.</li>
              <li>Fixed a rare bug which in some cases would permanently hide your crosshair.</li>
              <li>You can now set the minimap alpha value (overview_alpha) in the advanced options.</li>
              <li>All chat binds have been replaced with one single bind which simply opens the chat, the chat channel is chosen by pressing either the UP or DOWN arrow key.</li>
              <li>Daily quests are now rendered in a blue'ish overlay rather than the default orange'ish overlay. When you select/hover over the quest in the NPCs quest interaction panel or in your actual quest list panel. If it renders with a blue'ish background overlay it is a daily quest.</li>
              <li>Added a keybind helper HUD element which is rendered in the bottom left corner of the screen. This panel visualizes the most vital GUI panels and their associated keybinds.</li>
          </ul>

          <h5>Weapons & Combat</h5>
          <ul class="changelogitem">
              <li>Added crossbows and staves.</li>
              <li>Ranged weapons must now be charged for max damage and velocity.</li>
              <li>Added chance on hit logic, which can trigger a buff, debuff, stun or impairment/slow on a target. The buff will be triggered on the attacker though. This will trigger with a given probability.</li>
              <li>Stuns will freeze the target in-place, preventing the target from moving, attacking, etc...</li>
              <li>Movement impair effects like freeze/slow will reduce the movement speed of the target by 50%, and will reduce the targets attack and cast speed by 50%.</li>
              <li>Spells can also trigger buffs, debuffs, stunning and movement impairing.</li>
          </ul>

          <h4>Maps</h4>
          <ul class="changelogitem">
              <li>Forgotten Guardian will now do a Shield Slam attack which stuns the target for 5 sec.</li>
              <li>Servant of Keldroth's Whirlwind attack will trigger a freeze/slow effect on all targets struck.</li>
              <li>Skeletal Minions will no longer regenerate their HP.</li>
              <li>Added target dummies to Capital Outskirts.</li>
              <li>Extended the Wolves at the Gates quest, it is now a three series quest which involves the killing of Young, Elder and Magnificent wolves.</li>
              <li>Crushing Blow II tome will no longer be dropped by Skeletal Champion, it will only be dropped by Servant of Keldroth.</li>
          </ul>

          <h4>Balancing & Item Data</h4>
      <ul class="changelogitem">
              <li>Added a DoT to Fireball I.</li>
              <li>Added a DoT chance on hit to Heartbleed and The Ravager.</li>
              <li>Added shadow damage chance on hit for Doomhammer.</li>
              <li>Added shadow damage chance on hit for Shadowforged Longsword.</li>
              <li>Added healing chance on hit for the Scepter of Unholiness.</li>
              <li>Lowered the radius of Taunt from 200 to 160.</li>
              <li>Reduced the focus regeneration delay when casting a spell from 4 sec to 0.4 sec.</li>
              <li>Reduced shared spell cast cooldown from 0.5 sec to 0.25 sec.</li>
              <li>Boosted damage for all 2H melee weapons slightly.</li>
              <li>Boosted damage for all melee spells slightly.</li>
              <li>Upped drop percentage for rare loots dropped by bosses in Outskirts Catacombs.</li>
          </ul>

          <h4>New Items, NPCs, Quests & Spells</h4>
          <ul class="changelogitem">
              <li>Added Fiery Arrow I, the first ranged attack spell! Which also triggers a fire DoT.</li>
              <li>Added Shield Slam II, which also stuns the target for 3 sec.</li>
              <li>Added a bite spell to the current wolf NPCs, the bite will also trigger a bleed DoT.</li>
          </ul>

          <h4>Misc</h4>
          <ul class="changelogitem">
              <li>Added the latest SDK 2013 binaries.</li>
              <li>PvP Override can now be set in the zone data.</li>
              <li>Allow Mount can now be set in the zone data.</li>
              <li>Dungeon Size can now be set in the zone data.</li>
              <li>Added new textures for the Healing Circle and Shadow Circle.</li>
              <li>
                  <b>Reduced entity, NPC and player networking again, this time by more than 50%!</b><br>
                  Before:<br><img src="../assets/images/misc/net_before.jpg" width="400">
                  <br>
                  After:<br><img src="../assets/images/misc/net_after.jpg" width="400">
                  <br>
                  <i>(above comparison consisted of at least ~70 NPCs)</i>
              </li>
              <li>Refactored a lot of code, removed unused and unnecessary entities. Refactored the FGD files too.</li>
          </ul>
      </div>

      <div class="cont">
          <div class="date">
              2019-07-18 : Patch 1.0.1.0
          </div>
      <h4>Code</h4>
      <h5>Master Server</h5>
      <ul class="changelogitem">
              <li>Fixed a bug in the group system which would compute a faulty group size when someone left the group. Leading to group disband even if there were two players left in the group.</li>
              <li>Connectivity state is no longer relying on information from the gameservers, this will help ensure that you don't end up being left online forever in the system.</li>
              <li>Players can now reconnect to the master whenever, and initially players will now only be registered when they fully connect to the gameserver. Previously there could be scenarios where the gameserver tried to register players to the master too early which lead to inconsistencies.</li>
              <li>Changing major options on the client will no longer disconnect you from the master server until you reconnect manually.</li>
              <li>Improved caching algorithms when dealing with data packet broadcasting on the master.</li>
              <li>All chatting is now done through the master server, which will make it easier to implement the guild system in the future.</li>
              <li>When a gameserver is about to restart, quit or reload it will wait for all the userdata to be fully transmitted to the master before proceeding. To prevent potential packet loss.</li>
              <li>Fixed a minor rare bug which would prevent you from being set to online, if you connected at the moment the master disconnected you from the system.</li>
      </ul>

      <h5>NPCs</h5>
      <ul class="changelogitem">
              <li>Major AI overhaul, NPCs will now engage the players much faster. And will engage when attacked from afar.</li>
              <li>Combatants that use melee and ranged weapons will no longer switch weapon sets as frequently.</li>
              <li>NPCs can now have unique Walk and Run speeds.</li>
              <li>NPCs now run all their animation purely on the client and will properly suppress their AI when no players are around to save CPU cycles. Leading to an average cut of roughly 70-80% NPC networking!</li>
              <li>Improved YAW speed for NPCs, especially when they are in combat.</li>
              <li>NPCs will be able to attack you even if you stand ontop of them.</li>
              <li>NPCs can now drop a random set of money.</li>
              <li>Added Melee, Ranged and Magic damage scale options for NPCs. So that some NPCs can be buffed without needing to make new unqiue weapon items for those NPCs.</li>
              <li>Improved melee logic for monster NPCs, the Rats had a hard time attacking players when they were partially blocked by solids.</li>
              <li>Fixed NPC health regeneration logic, they will now regenerate their entire health pool within 15 sec by default.</li>
              <li>Melee Spells will never be cancelled.</li>
              <li>Fixed ranged NPCs, they are now establishing a proper line of sight and will cancel plus retry LOS properly when occluded.</li>
              <li>Threat Reset Spell Effect will now reset everyone to a random threat rather than setting everyones threat to 0 which would not lead to a random selection at all.</li>
              <li>Increased min and max idle wander distances, so that the NPCs walk around some more.</li>
              <li>NPCs that are returning to spawn, running a patrol route, etc will never be suppressed when no players are around.</li>
              <li>Players can now +use guards for some top-notch quality interacitons... NOOO!</li>
              <li>NPCs can now use attack speed, the lower the value the faster the attack(s).</li>
              <li>NPCs will no longer friendly fire their allies when they die and have active spell objects up.</li>
          </ul>

          <h5>Entities</h5>
          <ul class="changelogitem">
              <li>Spell Projectiles will now be properly removed when hitting certain NPCs/solid entities.</li>
              <li>Added logic_stopwatch which can be used to trigger timed events. The timer is drawn on the HUD, just above the experience bar. This will be used in the Catacombs so that the players know how much time they have left to kill Moroes in order to get the treasure loots.</li>
              <li>Once a corpse or chest starts fading out you'll no longer be able to loot it!</li>
              <li>When corpses have been fully looted, or if they had no loots at all they will become FULLY non-solid. So that they don't prevent the players from looting further corpses, when they pile up.</li>
              <li>Compressed the scripted sequence entity, it can be used for quick sequences like overriding the idle anim and playing certain gestures.</li>
              <li>Players and NPCs now have proper client-side baseflex features like blinking, head movement, body tilting, etc... This can be disabled through the options for performance reasons.</li>
              <li>Fixed multiple issues in the func_player_blocker entity, it will now block players properly and smoothly.</li>
              <li>If you enter the volume of func_player_blocker and become invalid you can be teleported to a specific point defined in that entity. Otherwise you'd be stuck forever.</li>
              <li>point_template will now properly precache custom NPCs so that the server won't lag when they spawn later on.</li>
              <li>Spell Explosions will no longer do any damage falloff or damage block reduction stuff.</li>
              <li>Added target_dummy, which can be used for testing melee, ranged and magic damage!</li>
              <li>logic_entity_counter can now filter entities based on NPC or Player ID.</li>
              <li>logic_entity_monitor can now filter entities based on NPC or Player ID.</li>
          </ul>

      <h5>Players</h5>
      <ul class="changelogitem">
              <li>Local Chat is now local to the zone rather than the gameserver, meaning that you can chat with other players that reside in the zone regardless if they are physically in the gameserver. So now you can for example chat with other players running the Catacombs dungeon, to exchange assistance if needed!</li>
              <li>You will no longer get stuck in combat when dying to an NPC.</li>
              <li>Invalid enemies will be removed regularly to prevent combat stuckness issues.</li>
              <li>Health regeneration while in combat has been reduced from 50% to 15% of the default rate. Now that Stamina increases health regeneration rate it was sensible to tweak the combat regeneration rate as well.</li>
              <li>Taunt will no longer do lots of damage.</li>
              <li>You can no longer crash the server by attacking with ranged or magic and disconnecting at the moment you execute the attack.</li>
              <li>You can no longer friendly fire Guards and Players by disconnecting at the moment you attack with spells or ranged.</li>
              <li>Fixed a bug which prevented a certain player from being invited to groups, if that player didn't properly trigger the group decline function.</li>
              <li>Fixed a bug which prevented trading, if the trade cancel function was never called properly.</li>
              <li>Increased max focus from 256 to 1000.</li>
              <li>Attack power has been split into two stats, Melee and Ranged attack power so that ranged can be balanced properly.</li>
              <li>Agility will increase ranged attack power.</li>
              <li>Stamina will now increase health regeneration.</li>
              <li>Intellect will now increase total focus pool.</li>
              <li>Consumables will now print to the combat log and potentially spawn combat 3D text as well.</li>
              <li>Fixed a bug in the active player counter reported in the main menu.</li>
              <li>Fixed a lot of infamous group loot bugs, players that leave the server, disconnect, or roll on invalid loot will auto-pass so that the loot becomes available right away if everyone else rolled/passed.</li>
              <li>Looting chests while in a group will no longer break the game by opening an invisible panel which cannot be closed!</li>
              <li>When the roll panel is triggered, the loots being rolled for will be dispatched to everyone in the group regardless of PVS. And if you are in a dungeon, it will transmit regardless of group ID to make sure that people cannot ninja.</li>
              <li>Loot Roll distance has been increased by roughly 100% in non-dungeons.</li>
              <li>Whenever you kill NPCs in a dungeon, everyone will be added to the loot table, regardless of group ID.</li>
              <li>Holstering weapons will properly cancel melee attacks.</li>
              <li>Added a Loot All option when looting corpses and chests.</li>
              <li>Removed voice chat logic.</li>
              <li>When you trigger a spell object such as the healing circle it will now be properly rendered in the exact position it will be spawned.</li>
              <li>Removed walking logic.</li>
              <li>Optimized the client animationstate for players, prevented excessive sequence lookup calls.</li>
              <li>Removed legacy player logo and spray code.</li>
              <li>All non-unique items will now have a limited max quantity of 100, if you increase the total quantity beyond that you'll create a new item with the specified quantity. Aka, proper quantity distribution!</li>
              <li>Fixed potential issues where picking up or handing in a quest would fail because it thought you didn't have enough room in your inventory.</li>
              <li>If you win multiple rolls, those items will no longer be put in the same slot!</li>
              <li>You can no longer access or update the bank while in combat.</li>
              <li>You can now swap items as long as the item ID and quantity is not the same for both of the items.</li>
              <li>You can no longer enter a dungeon accidentally if you have not been fully verified by the server.</li>
              <li>Updated the default camera offset to -5 UP and 19.5 RIGHT.</li>
              <li>Looting corpses or chests will open the looting menu even if the roll menu popped up.</li>
              <li>You can no longer use spells to heal or attack someone who is dead.</li>
              <li>Health regeneration will no longer reset when you take damage.</li>
              <li>When you attack another player you'll enter combat properly.</li>
      </ul>

      <h5>GUI & HUD</h5>
      <ul class="changelogitem">
              <li>Changing audio settings will no longer crash the game.</li>
              <li>The quick reply feature now works properly, it will no longer be overriden by anyone chatting in the Global, Group or Local chat. The reply ID will also last through connection sessions, but will be reset once you change to another character.</li>
              <li>Added a new special GUI action button which can be used to enable input for certain panels, trigger item comparison, trigger quantity-split-merging logic, etc...</li>
              <li>By holding the special GUI action button you can compare underlying items in your inventory, quest log, merchant view, etc with equipped items.</li>
              <li>By holding the special GUI action button you may enable mouse input for the loot roll panel and group invite panel.</li>
              <li>By holding the special GUI action button and left clicking on an item you will trigger a function which will allow you to extract a certain quantity from the item. Can only be used on non-unique items.</li>
              <li>By holding the special GUI action button and right clicking an item in the inventory when the merchant view is up you will sell the entire item, if the item is not unique. Rather than selling one quantity at a time.</li>
              <li>By holding the special GUI action button and left clicking a purchasable item in the merchant view you will be able to choose how many stacks you wish to buy. Will only work for non-unique items.</li>
              <li>You can no longer paralyze players by spamming group invites, the group invite GUI will not have input by default. Hold the special GUI action key to enable input.</li>
              <li>Loot Roll panel will no longer swallow mouse and keyboard input, when your group receives loot that should be rolled for simply hold the special GUI action key to enable input for this panel so that you can choose to roll or pass.</li>
              <li>Loot Roll panel items are now more compact, updated their visual design.</li>
              <li>Updated roll notification chat messages to have better colorization, so that players can distinguish the notifications properly. Also added personal notifications for the local recipient.</li>
              <li>Quest Objectives are now being rendered properly in the Quest Log panel.</li>
              <li>Quick Item Selection feature will no longer list items in the bank!</li>
              <li>NPC Dialogue in the Interaction Panel will no longer appear cropped for some resolutions.</li>
              <li>It is now a lot easier to remove spells from the action bar.</li>
              <li>It is now possible to re-organize your inventory in the merchant panel, like you'd expect.</li>
              <li>Added a buyback feature, whenever you sell something to a vendor you'll be able to buyback the item you sold if it was a mistake. The server will only keep the 18 latest items in the cache, and will only last throughout one session. So if you reconnect, switch characters or leave the map it'll be purged.</li>
              <li>Added a Resume Game button in the main menu while in-game.</li>
              <li>Cooldowns are now more noticable and will render properly across different maps/sessions.</li>
              <li>Added 3D healthbars for NPCs and Players. Enable them through the options.</li>
              <li>It is now possible to show finished quests, this can also be enabled through the options.</li>
              <li>Tomes will now let you know whether or not you've learnt that specific tome.</li>
              <li>Items that cannot be traded will specifiy so in the tooltip.</li>
              <li>By default all quests will be auto-tracked, the auto-track limit and whether or not every new quest should be tracked can be changed in the options.</li>
              <li>Players or NPCs that have a much greater level than yourself will have their name rendered in a dark-red color. (danger)</li>
              <li>Crosshair should no longer randomly disappear forever when you change certain video options.</li>
              <li>Improved the Info Sign VGUI Screen, it should now render the label more consitently. With a proper white foreground color and no background color.</li>
              <li>
                  Updated rarity colors
                  <ul>
                      <li>Junk - Grey</li>
                      <li>Common - Green</li>
                      <li>Rare - Light Blue</li>
                      <li>Epic - Purple'ish</li>
                      <li>Legendary - Orange'ish</li>
                  </ul>
              </li>
              <li>Scrollbars are no longer super slow.</li>
              <li>If you are the leader of some group and leave when the group size is greater than 2, you will be notified of the new group leader.</li>
              <li>Added dropshadow outline to quest objectives and quest list items.</li>
          </ul>

          <h5>Weapons & Combat</h5>
          <ul class="changelogitem">
              <li>Weapons will do multiple world decal traces, should be improved further later on though.</li>
              <li>Improved hit detection for NPCs and Players. NPCs will no longer cut their attacks, or do a limited amount of attack traces.</li>
          </ul>

          <h4>Maps</h4>
          <ul class="changelogitem">
              <li>Moroes the Summoner will remove his minions on death. On sacrifice Moroes will heal himself for 15% of his total health rather than 10%. And the sacrifice will be triggered everytime he loses 35% health. However he will no longer check the sacrifice logic while someone is being sacrificed, so that he won't sacrifice another player right away when the previous sacrifice ended. Plus the minions will not be removed anymore, unless if Moroes dies or leaves combat.</li>
              <li>Harold will no longer print his dialogue when you +use the cage after rescuing him.</li>
              <li>Fixed minor navigation issues in Capital Outskirts near the Commanding Smugglers.</li>
          </ul>

          <h4>Balancing & Item Data</h4>
      <ul class="changelogitem">
              <li>2H Weapon range has been reduced by 5 units.</li>
              <li>Stamina will increase health regeneration by 0.165HP/s per point.</li>
              <li>Intellect will give one spellpower per point rather than 3.</li>
              <li>Intellect will increase total focus pool by 0.625 per point.</li>
              <li>Agility will increase ranged attack power by 3 per point.</li>
              <li>Each point of melee attack power will increase damage by 0.75 rather than 0.90</li>
              <li>Each point of spellpower will increase damage by 0.50 rather than 0.60.</li>
              <li>Each point of ranged attack power will increase damage by 0.335.</li>
              <li>Berserker's Helmet Melee Attack Power has been reduced from 50 to 20.</li>
              <li>Shield of Vengeance has been buffed, armor has been increased by 6, and agility by 1.</li>
              <li>Broken Skull price has been reduced from 5 to 2.</li>
              <li>Smuggler Lite experience has been buffed by 35.</li>
              <li>Commanding Smugglers will deal 15% more damage.</li>
              <li>Young and Elder Wolves have had their experience buffed by 15 and 25 respectively.</li>
              <li>Guards will do 100% more damage.</li>
              <li>Smuggler Legionnaire will do 50% more damage.</li>
              <li>Demonic Rat experience has been nerfed by 50.</li>
              <li>Skeletal Ranger experience has been nerfed by 100.</li>
              <li>Buffed Moroes the Summoner's health by 250, melee damage by 20% and magic damage by 100%.</li>
              <li>Nerfed Moroes the Summoner's experience by 250.</li>
              <li>Forgotten Guardian is not as resistant to magic anymore, nerfed by 50%.</li>
              <li>Nerfed Forgotten Guardian experience by 250.</li>
              <li>Buffed Shadow of Keldroth to deal 25% more damage.</li>
              <li>Nerfed Shadow of Keldroth experience by 500.</li>
              <li>Nerfed Skeletal Berserker experience by 200.</li>
              <li>Skeletal Berserker will attack 30% faster, will deal 50% more damage with melee and 35% more damage with ranged.</li>
              <li>Nerfed Skeletal Avenger experience by 300.</li>
              <li>Nerfed Skeletal Champion experience by 500.</li>
              <li>Nerfed Skeletal Minion health by 150.</li>
              <li>Nerfed Skeletal Minion experience by 100.</li>
              <li>Skeletal Minions are 25% less resistant to magic.</li>
              <li>Moroes the Summoner quest will give 2500 less experience and 500 less coins on completion.</li>
              <li>Changed focus cost for Melee Smash II from 75 to 55.</li>
              <li>Shadow of Keldroth's Whirlwind I spell will have a greater knockback, less cooldown and do 5 more damage.</li>
              <li>Healing Circle I will heal every 4.5 sec rather than 4 sec, and will do 10-20 healing rather than 14-33.</li>
              <li>Shadow Circle I will damage every 3 sec rather than 2.5 sec, knockback has been buffed by 25 and damage has been nerfed by 12.</li>
              <li>Healing Touch I has been nerfed from 47-64 healing to 25-35 healing.</li>
              <li>Healing Touch I cooldown has been changed from 7.5 sec to 0.5 sec.</li>
              <li>Healing Touch I cast time has been changed from 3 sec to 2.25 sec.</li>
              <li>Healing Touch I range has been increased from 300 to 350.</li>
              <li>Healing Touch I focus cost has been changed from 30 to 25.</li>
              <li>Skeletal Minions movement speed has been nerfed by 60%.</li>
              <li>Skeletal Ranger will do 50% more ranged damage.</li>
              <li>Buffed Shield Slam I damage by 5.</li>
              <li>Buffed all 2H weapon damage by roughly 50%.</li>
              <li>Increased the range of Taunt by 25.</li>
              <li>Taunt will no longer have a large cooldown, nerfed it down to 10 sec.</li>
              <li>Taunt will now increase threat a lot more, which will increase the likelyhood of being attacked by the affected NPCs.</li>
              <li>Fireball I cast time has been reduced from 3.5 sec to 2 sec.</li>
              <li>Increased max breath under water by 50%.</li>
          </ul>

          <h4>New Items, NPCs, Quests & Spells</h4>
          <ul class="changelogitem">
              <li>Added a new daily quest for the Catacombs dungeon.</li>
              <li>Removed level requirement from all equippable quest rewards.</li>
              <li>Made sure that you cannot trade any equippable quest reward items.</li>
          </ul>

          <h4>Misc</h4>
          <ul class="changelogitem">
              <li>Fixed a strange crash which would only happen if you sat the model quality to low.</li>
              <li>Fixed multiple textures with messy reflections.</li>
              <li>Fixed Wolves walk anim, they are no longer rotating all over the place.</li>
              <li>Improved Discord RPC to include proper images of the maps you're playing in, and report your character name plus level.</li>
              <li>Loot Drop Chances are now using a new and more accurate random engine.</li>
              <li>Optimized navmesh logic so that we don't generate tons of useless metadata and areas. Disabled JUMP, CROUCH and CLIMB areas. For reference, Capital Outskirts NAV file got reduced by 55 MB thanks to these changes... Apparently the default NAV takes up most of the in-game memory as well.</li>
              <li>Removed tons of legacy HL2 code and entities!</li>
              <li>Hashed the VPKs so that the game will load a little faster.</li>
          </ul>
      </div>

      <div class="cont">
          <div class="date">
              2019-01-14 : Patch 1.0.0.9
          </div>
      <h4>Code</h4>
      <h5>Core & Misc</h5>
          <ul class="changelogitem">
              <li>Added support for Discord RPC, on Windows.</li>
              <li>Added full dedicated server support for Linux!</li>
              <li>Major performance & network optimizations + refactoring.</li>
              <li>The Item Creator tool is now available to the public!</li>
              <li>NPCs & Player Models will no longer twitch randomly and uncontrollably, thanks to a fix provided <a href="https://github.com/ValveSoftware/source-sdk-2013/issues/404#issuecomment-405042224" target="_blank">here</a></li>
              <li>buildcubemaps will no longer cause the game to enter a deadlock.</li>
              <li>Applied a simple fix for the FMOD mute logic, whenever a new sound would play, the volume would not be set to 0, if mute was enabled. So for a brief second you would hear tiny high pitch noises every time a new sound was being played.</li>
              <li>Added graceful termination for Linux DS, using a proper signal handler.</li>
              <li>All gameservers will now set -nohltv by default, to prevent hltv from taking up an unnecessary port for each server.</li>
              <li>Fixed a race condition which would occur when a client connected to a server, the client would execute a ClientCMD on another thread, while already executing other ClientCMDs on another thread!</li>
              <li>Added new localization files, gamemisc_english and gamedata_english. The first one is used for map localization, while the second one is used for all item localization, automated through the ItemCreator tool.</li>
              <li>Reverted to 66 tickrate for local test servers, dedicated servers use 33 tick by default.</li>
              <li>Improved debugging for the master & gameserver + RakNet debugging. Using the sv_debug_raknet cvar.</li>
              <li>Removed a lot of legacy code and content.</li>
              <li>Boss Corpses and Treasure Chests will not despawn in dungeons!</li>
      </ul>

      <h5>Master Server</h5>
      <ul class="changelogitem">
              <li>Fixed some strange exceptions related to item equipping, in some cases where you would unequip, re-equip, swap items, it would crash when storing the changes to MySQL.</li>
              <li>Fixed bad quantity removal, some items would have their quantities decreased twice.</li>
              <li>Added proper password support.</li>
              <li>Added an online client list, so we don't have to iterate through too many players in the long run, when we don't care about offline users.</li>
              <li>Player names are being properly hashed, so that we can do lookup by name faster, for instance when adding a friend, inviting someone by name, etc...</li>
              <li>Optimized many calls to use the new online client list, rather than checking through a much larger list, when we only care about online users.</li>
              <li>Fixed sorting issues if the data had to be sorted using an integer greater than 32-bits.</li>
              <li>Improved speed of sorting algorithms used.</li>
              <li>Gameservers will not send any data before they have been successfully registered @ master.</li>
      </ul>

      <h5>NPCs</h5>
      <ul class="changelogitem">
              <li>Added interaction dialogue messages, which will be triggered if you were unable to interact with an NPC.</li>
              <li>Non-BaseCreature NPCs will now be fully immortal, NPCs like Seagulls, Crows, etc...</li>
              <li>NPCs will now use proper pathfinding when trying to flee from an enemy.</li>
              <li>NPC names are now being localized.</li>
              <li>NPC Auto-Spawner will use a smaller HULL when checking whether or not an NPC can be respawned in its original position, checking for free space.</li>
              <li>Fish NPCs will panic whenever someone dies near them.</li>
              <li>NPCs will fade-in on spawn. NPCs can also be faded-out before being killed, corpses will also fade-out.</li>
              <li>Corpses will fade-out.</li>
              <li>Optimized NPCs network vars, to save as many bits as possible...</li>
              <li>If an NPC is returning to spawn, other NPCs will ignore this NPC, even if they are enemies.</li>
              <li>Added InputPrintDialogue input, which can be used to print dialogue to nearby players.</li>
              <li>Improved NPC Squads to properly communicate whenever an NPC needs help, for example when an NPC wants to flee, the NPC will run to a nearby ally, and return with aid.</li>
              <li>You can set if an NPC should notify all of its squad members regardless of distance, when being attacked. Defaults to distance based, if you engage with an NPC in a squad, the NPC will tell its squad mates to come help.</li>
              <li>NPCs can now use ranged weapons, and will prioritize ranged weapons over melee whenever possible.</li>
              <li>NPCs will notify other allies whenever they took damage from an NPC or Player.</li>
              <li>Added TypeOverride for npc_static, so that a dialogue based NPC can still be used as a banker NPC for example.</li>
              <li>Improved AI when in a dungeon, NPCs will chase enemies forever if in a dungeon.</li>
              <li>Made some minor changes to how factions work for NPCs, NPCs that have a relationship ID will become your enemy if you have less than 0 reputation for that repID, only if this NPC is set as an ally for that relationship ID, otherwise neutral.</li>
              <li>Added massive changes to the AI Spellcast Behavior, NPCs can now cast projectiles, spell objects, AOE spells, healing spells, heal allies, any melee/ranged spells, etc... Plus they will now use a proper cooldown system! And play the appropriate spell sounds.</li>
              <li>Thanks to the new Spellcast Behavior changes, NPCs will select their spells more wisely, prioritizing magic whenever possible.</li>
              <li>Fixed NPCs assuming that every Main Hand slot weapon was a 2H weapon.</li>
              <li>Added NPC Escort functionality, simply do StartEscort, the activator must be a player if you want to progress a potential quest related to the escort. This new feature will allow mappers to make quests where you have to either protect or escort some NPC.</li>
              <li>If an NPC is following a patrol route, OnPass will be fired for each node reached, if using path_corner, or path_corner_crash.</li>
              <li>NPCs will regen health more rapidly when not in combat.</li>
              <li>Added KillFade Input, can be used when you want to kill the NPC but want the NPC to fade-out first, won't spawn a corpse! (client-side fade)</li>
              <li>NPCs can now dual wield properly.</li>
              <li>Fixed NPC engaged idle anims, they should play properly now when an NPC is in combat.</li>
              <li>In Hammer you can set if an NPC can Flee or not, set the blood color/type and the hull type/size.</li>
              <li>Setting the Long Range/Distance Shoot flag for NPCs will no longer break their AI, previously this flag would give their weapons infinite range, so they wouldn't bother moving.</li>
              <li>Added support for patrol interruption strictness, you can set if the npc should care to engage in combat, or only if blocked, etc...</li>
              <li>NPCs max armor has been set to 2000.</li>
              <li>Added new dropchance calculation logic, it should be more randomized now.</li>
          </ul>

          <h5>Entities</h5>
          <ul class="changelogitem">
              <li>Added 'master' support for checkpoint entities, to prevent people from spawning in (0,0,0) if no checkpoint was available.</li>
              <li>Soundscapes now work properly for Linux systems.</li>
              <li>Soundscapes are now fully client-side, rather than using the server to figure out for each player which soundscape they should trigger, this is now done per-local-player-locally! Simply by checking if you're within any of the defined soundscapes. See func_soundscape, func_soundscape_simple, func_soundscape_area for more.</li>
              <li>You can also define a default soundscape for your map through the map properties, if you want to trigger this particular soundscape no matter what, when no other soundscape is available/nearby.</li>
              <li>Glow Outline Color is now fully client-side.</li>
              <li>Reworked client-side gib code.</li>
              <li>Added logic_npc_dialogue, which can be used to print NPC dialogue for a specific NPC even if that NPC is not in the actual map, if in a dungeon it will print to all players by default.</li>
              <li>point_viewcontrol will now apply to everyone in the map, can be used in dungeons for small cutscenes. These cutscenes can be interrupted locally by hitting the JUMP button.</li>
              <li>Added item_chest, a treasure chest, can be used to distribute secret/rare snacks. Works like regular looting, when looting a corpse.</li>
              <li>Spell Projectiles + Arrows now use a proper collision group, to prevent them from colliding with each other.</li>
              <li>Spell Projectiles should be removed properly now, previously the entity would linger, even for minutes after impact...</li>
              <li>Disabled blood decals from being emitted.</li>
              <li>Model particles have been fully fixed to work for Infestus, the model particles will also be properly purged whenever the model changes or the entity is removed. Also fixed a memory leak which would occur when parsing the particle keyvalues and not finding the particle or attachment itself, it would return prematurely.</li>
              <li>Spell Objects will now do proper damage impacts.</li>
              <li>Added universal input to toggle entity collision (ToggleCollision), can be used for doors, if you don't want the door to be affected by NPCs or players, simply disable its collision, this is also good for navmesh, since the door will block parts of the nav when opened.</li>
              <li>Added game_chat, similar to game_text, however this entity simply prints to the chat instead, no fancy effects.</li>
              <li>Added a new collision group which can be used for NPCs and Players when we fear they might be stuck or if they might get stuck, enabling this collision group will disable collision until there is space.</li>
              <li>Fixed a rare exploit which could be used by players to loot corpses that didn't belong to them.</li>
              <li>Added ProgressAll for logic_quest_progress, this can be used to progress a quest for everyone in a dungeon or in a group.</li>
              <li>Players & NPCs can now cast more complex spells.</li>
          </ul>

      <h5>Players</h5>
      <ul class="changelogitem">
              <li>Added AFK Kick manager, the max AFK time depends on the map type, whether you are in the lobby, a dungeon or in the world.</li>
              <li>Added major fixes to the thirdperson camera, it now updates more smoothly with the world, little to no clipping through the world.</li>
              <li>Added thirdperson camera alpha changes when the camera zooms-in further than the minimum distance, making your player + armor + weapons transparent so that your view won't be fully obscured in this situation.</li>
              <li>You can no longer do camera free rotation while dead.</li>
              <li>Fixed cam collision while dead, should no longer clip through floor.</li>
              <li>Holding in free rotation before dying and not letting go until respawning would leave your character in a permanent free view mode, this has been fixed.</li>
              <li>Fixed issues related to trading, if you traded multiple items of the same ID, you would only trade one of these items successfully, meaning you'd lose the rest!</li>
              <li>Fixed ClientCommand/MasterBroadcast issues which could occur if you had a large ping and sent multiple commands within a short time period, this could result in the server processing the same stuff more than once, normally this is not a problem, but when you want to hand in a quest, you could've handed it in twice!</li>
              <li>Dormant armor and weapons will no longer do any thinking.</li>
              <li>Removed client-think for players, except for the local-player.</li>
              <li>Prevented a potential exploit which would allow a player to hand-in a quest to any NPC if certain conditions were met.</li>
              <li>Added a time-out feature for the dungeon loading screen, if you wait longer than 2 min, you will be disconnected from the dungeon, assuming it didn't start.</li>
              <li>Added a dungeon limit reply, if there is no dungeons available, you will be notified of this.</li>
              <li>Bots are now working properly, can be used for testing purposes, in a local game. Use RemoveAllTestBots to kick all bots from the game, if needed.</li>
              <li>Money is now being clamped properly to prevent it from going out of range.</li>
              <li>You can no longer halt your respawn timer by holding down any buttons.</li>
              <li>Fixed player death angle and animation, should no longer glitch up for players entering the PVS just after someone died, or for instance if you entered the game after someone recently died, stuff will be rendered correctly.</li>
              <li>Added support for ranged weapons.</li>
              <li>Whenever you attack with ranged weapons, your arrows will glow locally, to help you see the trajectory, especially in darker areas.</li>
              <li>Fixed a null-pointer crash in the footsteps code.</li>
              <li>Fixed a bug in the inventory and banking system, basically you could move an item onto another item, and not do a swap, if you didn't know that there was in fact an item already in that slot, if the master disconnected due to a crash you could move items onto other items, stacking them all in the same slot. When the master came back up, you'd suddenly have those items in one slot.</li>
              <li>You can no longer enter a dungeon when you are dead, observing, not fully connected or when in combat.</li>
              <li>Added a teleport sound which will play whenever a player is being teleported.</li>
              <li>Added missing JUMP animevent.</li>
              <li>Players will no longer play engaged animations when all weapons have been holstered.</li>
              <li>Combat State has been improved, you should no longer be plagued by 'You cannot do this while in combat' stuff, when you recently left combat.</li>
      </ul>

      <h5>GUI & HUD</h5>
      <ul class="changelogitem">
              <li>Fixed some minor issues related to the user search feature, some systems would not register the ENTER key, which would trigger the search itself, now it may trigger directly as you write.</li>
              <li>You can no longer swap equal items between bank and inventory, for now.</li>
              <li>You can now see your reputation state for each reputation, simply hover over the reputation value to see your standing.</li>
              <li>Fixed Quest Tracker HUD, sometimes the tracker HUD would report faulty values.</li>
              <li>Fixed invalid pointers being stored for some HUD elements.</li>
              <li>Added quest auto-tracking feature, which is triggered if you for example hand-in a quest, and then pickup a follow up quest which required the quest you just handed-in, this will auto track the new quest.</li>
              <li>You can no longer open any GUI menus in the lobby map.</li>
              <li>Fixed various HUD & GUI issues on Linux/OSX, the 2D Info HUD would only render the first letter of an NPC or Player name.</li>
              <li>Reworked the Item Tooltip logic, it is now rendered properly, more compact, and will clamp to the screen if it becomes too large.</li>
              <li>Misc/Ranged weapon will be rendered on the back, in the character preview screen, rather than in the left or right hand, which would be weird if you also had a main & off hand weapon equipped.</li>
              <li>Your ping and world number will now be rendered in the bottom right corner of the main menu, the amount of players online in all of the worlds combined will also be displayed there, plus other misc stuff.</li>
              <li>Fixed a horrible bug which would break the Item Tooltip rendering, if you had a low fps, lower than 25, the tooltip would flicker or not render at all, due to some inefficient visibility check that would not be called often enough if you had lower than 25 FPS.</li>
              <li>Item Tooltip will now display both negative and positive values for different stats.</li>
              <li>The mouse cursor will now be properly positioned in the middle of every GUI panel, however on Linux it may not center properly, yet.</li>
              <li>Experience bar and text will no longer be rendered at max level.</li>
              <li>Layout and update response times in the inventory GUI should be faster.</li>
              <li>Character Stats will now show negative values, if any. Plus the armor stat will show exactly how much damage reduction you will do for your level, and how much move speed + cast speed changes have been applied.</li>
              <li>User Search will now display how many results were found compared to the total online players active throughout the master itself. (all worlds)</li>
              <li>Clamped progress bars for XP, health and focus to stick between 0-1, in some cases the progress bars could've been rendered wrong if for some reason this fraction went out of range.</li>
              <li>Added a combat indicator, on your local character HUD in the top left corner, there will be a flashing red circle behind your character model.</li>
              <li>Item Tooltip sell price, Merchant Buyout Price, etc... now use the money icon instead of just plain text.</li>
              <li>You can no longer spam other players by inviting them continuously, which would reset their notification panel state every time. The same fix has been applied to the trading panel.</li>
              <li>Updated Quest Tracker title colors, when the quest is ongoing/not finished it will render in a cyan/brown color, if it is finished it will render as green, red if failed.</li>
              <li>Fixed character HUD being delayed slightly for the local user, due to waiting for the playerID to be set on the next frame.</li>
              <li>Made sure to set default values for the character preview debug cvars.</li>
              <li>Minimap will no longer go crazy/twitch when you die while allow rotation is enabled.</li>
              <li>Added an option to render minimap transparently, with no background or border image. If disabled, a black background will be rendered + the frame.</li>
              <li>3D Info HUD (NPC Names & Corpse Names) can now be disabled through the options, you can also set the max amount of names to render at once, I've also made sure that any names that render at an angle greater than 90 from your view will not be rendered at all.</li>
              <li>Fixed potential crash in the loading screen GUI.</li>
              <li>Ban reason message should now appear correctly if you are disconnected from a server due to ban.</li>
              <li>Fixed potential buffer overflow issue in the chat system.</li>
              <li>Chat Channels have now been given unique colors, Global & Local uses the same color, Whisper/Private has its own color and Group chat has its own color.</li>
              <li>If an NPC or Corpse is fading in/out, 3D info and 2D info will not be rendered for this entity.</li>
          </ul>

          <h5>Weapons & Combat</h5>
          <ul class="changelogitem">
              <li>Improved melee hit detection further, also made sure that attacks will not affect enemies who are directed roughly greater than 75 degrees from the attack position, meaning you are fully safe when attacking someone from the behind.</li>
              <li>Equipping a new weapon while having a weapon drawn, will draw this weapon directly, assuming it was an off-hand or main-hand, while having melee drawn.</li>
              <li>Weapon data no longer cares about weapon pos and angle, the wielder model will have defined some necessary attachments, which have the predefined perfect position and angles instead.</li>
              <li>Weapon position & angle is now updated in realtime @ client, it has a much more accurate position than before, previously you could notice that the weapon did not always move perfectly with an NPCs or Players hand.</li>
              <li>Improved the Combat Log HUD to display damage reduced due to Armor, Resistances and Blocking, a simple damage report.</li>
          </ul>

          <h4>Maps</h4>
          <ul class="changelogitem">
              <li>Added Capital Outskirts Catacombs dungeon map. You can get extra rare loots if you complete the dungeon in less than 15 min! (HARD ~ bring 4 pals)</li>
              <li>Fixed flickering windows @ Cathedral in Capital Outskirts</li>
          </ul>

          <h4>Balancing & Item Data</h4>
      <ul class="changelogitem">
              <li>Changed how armor works, armor is now calculated using this formula: Level*Level + Level*11 + 65, this represents the max armor for the desired level, if you have max armor or more, you will reduce melee or ranged attacks by 65% if the opponent is equal to your level, otherwise you use the smallest level and check how much armor you can decrease against that level.</li>
              <li>Max Armor will slow you down by maximum 25%.</li>
              <li>Max Armor will slow your casting speed by maximum 35%.</li>
              <li>Agility will increase your running speed by maximum 50%.</li>
              <li>Intellect will decrease casting time by maximum 30%</li>
              <li>Ring of Immense Power and Warrior's Blessing have been changed, you can now buy more rings, with different type of stats to satisfy different kind of builds.</li>
              <li>It is now possible to add items with sell price 0, meaning FREE.</li>
              <li>Weapons now have an extended set of flags, so we can define different behaviors for different weapon types.</li>
              <li>Armor & Weapons can now increase or decrease your total focus value.</li>
              <li>Food items will now have a short cooldown when consumed.</li>
              <li>Spells now have a much more concrete layout, allowing for more variety.</li>
              <li>Added support for pure junk inventory items.</li>
          </ul>

          <h4>New Items, NPCs, Quests & Spells</h4>
          <ul class="changelogitem">
              <li>Added 2 2H weapons, blunt weapons, with new animations!</li>
              <li>Added 3 1H weapons.</li>
              <li>Added 2 gloves.</li>
              <li>Added 4+ helms.</li>
              <li>Added 1 chestguard.</li>
              <li>Added 2 bows.</li>
              <li>Added 10+ shields (not all are obtainable yet, 7 are obtainable now!)</li>
              <li>Added 3 rings.</li>
              <li>Added a new necklace.</li>
              <li>Added 6 new awesome spells, proper tanking spells are amongst them.</li>
              <li>Added 5 new quests for the new dungeon map! Get crackin, folks!</li>
              <li>Added 10 new NPCs.</li>
              <li>+ Various misc items...</li>
          </ul>

          <h4>Misc</h4>
          <ul class="changelogitem">
              <li>Optimized the game folder, it should now be roughly around 3GB! (the dedicated server is less than 700MB)</li>
              <li>Game should boot & load faster!</li>
          </ul>
      </div>

      <div class="cont">
          <div class="date">
              2018-04-21 : Patch 1.0.0.8 Hotfix 1
          </div>
      <h4>Code</h4>
      <h5>Core</h5>
          <ul class="changelogitem">
        <li>Optimized glow outline effect.</li>
        <li>Optimized 3D info HUD.</li>
        <li>Fixed a crash related to the glow effect.</li>
      </ul>

      <h5>NPCs</h5>
      <ul class="changelogitem">
        <li>NPCs can no longer be interrupted when they are returning to spawn, previously they would just stop moving if they were blocked.</li>
        <li>Fixed health and focus regen issues, NPCs should no longer regen super fast when leaving combat.</li>
      </ul>

      <h5>Players</h5>
      <ul class="changelogitem">
        <li>Changed the default keybind for toggling walking to keypad minus, to prevent random walk enable when you alt+tab out of the game, write exec config_default in the console to enforce the new config + keybinds.</li>
        <li>Nerfed knockback, especially in PvP.</li>
        <li>Added knockback support for spells, Arcane Blast will now knock enemies away.</li>
        <li>Fixed thirdperson camera, it is now slightly smoother and updates faster, prevents clipping through walls.</li>
        <li>Thirdperson camera will now be properly reset on connection.</li>
      </ul>

      <h5>GUI & HUD</h5>
      <ul class="changelogitem">
        <li>2D info HUD should now center-align properly on smaller and larger resolutions.</li>
        <li>Fixed a rare bug which would make the action HUD position at the far left corner instead of in the middle.</li>
      </ul>
      </div>

      <div class="cont">
          <div class="date">
              2018-04-15 : Patch 1.0.0.8
          </div>
      <h4>Code</h4>
      <h5>Core</h5>
          <ul class="changelogitem">
        <li>Major optimization for client & server, reduced costly code, improved expensive code. Data can be retrieved even faster, clients should expect decent FPS boosts, especially on a low end system.</li>
      </ul>

      <h5>NPCs</h5>
      <ul class="changelogitem">
        <li>Increased NPC chase distance by 50%.</li>
      </ul>

      <h5>Players</h5>
      <ul class="changelogitem">
        <li>Walking can now be toggled.</li>
        <li>When entering a server with dead players they should no longer go T-pose.</li>
        <li>Weapons will no longer have their angle or position prematurely updated while drawing or holstering.</li>
              <li>Fixed a bug which would allow the player to execute another spell based attack while currently doing a spell based attack, this would break the current attack.</li>
              <li>Improved melee accuracy slightly.</li>
      </ul>

      <h5>GUI & HUD</h5>
      <ul class="changelogitem">
        <li>Fixed a bug which would render group members in the wrong position in the minimap if they left your PVS.</li>
        <li>Fixed a potential bug which would allow the player to track the same quest twice.</li>
        <li>The 2D info view HUD should be more consistent and less laggy.</li>
      </ul>

      <h4>Balancing</h4>
      <ul class="changelogitem">
        <li>Increased movement speed while casting spells, speed will now be reduced by 25% instead of 50%.</li>
        <li>Movement speed will be increased by 0.098% per point of Agility</li>
        <li>Attack speed will be increased by 0.165% per point of Agility.</li>
        <li>All melee attack speeds have been tweaked, no weapons should be slower than 1.1 currently.</li>
          </ul>
      </div>

      <div class="cont">
          <div class="date">
              2018-03-27 : Patch 1.0.0.7
          </div>
      <h4>Code</h4>
      <h5>Core</h5>
          <ul class="changelogitem">
        <li>Fixed issues related to the new thread safety logic, players should no longer experience brief lag spikes.</li>
      </ul>

      <h5>Entities</h5>
      <ul class="changelogitem">
        <li>Corpses will now ignore +use if there is no loots available, this will ensure that no loot issues will occur if corpses pile up.</li>
        <li>Added trigger_pvp_zone which can be used to mark an area as a PvP zone or safe zone, in PvP only servers/maps safe zones can be used to create certain non-PvP areas. While PVE servers may have some PvP forced areas. Whenever you enter a PvP zone the minimap zone text will be rendered in red.</li>
      </ul>

      <h5>NPCs</h5>
      <ul class="changelogitem">
        <li>Increased idle distance and decreased idle check time.</li>
      </ul>

      <h5>Players</h5>
      <ul class="changelogitem">
        <li>Voice will be fully disabled for players further than 1000 units from the local player, group members will not be affected.</li>
        <li>Added many fixes to the thirdperson camera, proper collision handling, smoother transitioning, over the shoulder support, check advanced options for setting up your preferred camera style.</li>
        <li>Crosshair is now 100% accurate, spells will actually 'follow' the crosshair position now.</li>
        <li>+use'ing stuff is now more responsive and easier in general, now that the crosshair has been fixed.</li>
        <li>Added camera free rotation mode, press and hold MOUSE4 by default to enable this mode, while this mode is active you can rotate freely around your character.</li>
        <li>Added attack speed functionality, increased Agility skill will increase your attack speed.</li>
        <li>You can now do magic spells with any weapon active, your weapons will be holstered and re-drawn when the spell has successfully been casted.</li>
        <li>You can now move and jump while activating spells, however your movement speed will be reduced by 50% while casting.</li>
        <li>Weapon entities should update their position and angles more frequently.</li>
        <li>You can now cancel a spell by re-activating the same spell or another spell, clicking another spell will trigger that spell instead.</li>
        <li>Added remaining ranged weapon logic, however no ranged weapons are available yet!</li>
        <li>Fixed a bug which would occur when you tried to holster ranged weapons.</li>
      </ul>

      <h5>GUI & HUD</h5>
      <ul class="changelogitem">
        <li>Added NPC dialogue which will be printed in the chat, example:<br/><img src="../assets/images/misc/npcdialogue.jpg"></li>
        <li>Closecaptions, npc dialogue & subtitles will always be shown when in a dungeon or battleground. If you're in a world map it will be distance based.</li>
      </ul>

      <h4>Balancing</h4>
      <ul class="changelogitem">
        <li>Altered attack speed for all weapons.</li>
        <li>Adjusted the attack speed gained by Agility, you will now increase attack speed by 0.15% per point.</li>
        <li>Adjusted the movement speed gained by Agility, you will now increase movement speed by 0.275% per point.</li>
        <li>Adjusted the movement speed lost due to Armor, movement speed will be decreased by 0.085% per point of armor.</li>
        <li>Increased default focus regeneration rate by 0.25.</li>
        <li>Reduced default focus regeneration rate penalty wait time by 0.5 sec.</li>
          </ul>

          <h4>Other</h4>
      <ul class="changelogitem">
              <li>Fixed multiple typos in the localization file.</li>
          </ul>
      </div>

      <div class="cont">
          <div class="date">
              2018-03-18 : Patch 1.0.0.6
          </div>
      <h4>Code</h4>
      <h5>Core</h5>
          <ul class="changelogitem">
        <li>All non dungeon gameservers will be restarted at a certain time during the day, by default everyday at 4 am, to battle the VAR (lag) issues due to high uptime.</li>
        <li>Added proper thread safety for server and client. This should fix the rare crashes that have been reported.</li>
      </ul>

      <h5>NPCs</h5>
      <ul class="changelogitem">
        <li>Patrolling NPCs will no longer bug up when you engage them, Smuggler Legionnaire would randomly run back to the initial patrol point if he was too far away from it when engaged.</li>
      </ul>

      <h5>Players</h5>
      <ul class="changelogitem">
        <li>Added a simple magic lock-on algorithm for improved hit detection with magic spells, this is a temporary solution to the bugged crosshair angles.</li>
        <li>Fixed PvP with melee weapons.</li>
        <li>Voice proximity will be disabled between group members.</li>
        <li>Fixed a major bug in the group system, if the group leader left the group, the group would break.</li>
        <li>Updated max playerID value in infestus_selected_player/last_player cvars.</li>
        <li>Fixed miss calculated equip stats on connection, level-up + weapon stats were omitted.</li>
        <li>Equipped items will now be verified on connection.</li>
        <li>Fixed multiple issues in the item slot system, you could potentially lose items due to some messy code and queries.</li>
      </ul>

      <h5>GUI & HUD</h5>
      <ul class="changelogitem">
        <li>Quest tracker & notifier has been optimized.</li>
        <li>Interaction panel quest item overlay will no longer 'flicker'.</li>
        <li>Bosses will no longer render their level.</li>
        <li>Spell action bar is more responsive.</li>
        <li>Finished quests will be rendered in green, both in the quest log and in the interaction panel quest items list.</li>
        <li>Minimizing quest categories will no longer bug up.</li>
        <li>If you are in a group, the group leader will be rendered in yellow text @ name.</li>
      </ul>

      <h4>Maps</h4>
      <h5>Capital Outskirts</h5>
      <ul class="changelogitem">
        <li>Increased the respawn time for several quest items.</li>
        <li>Felix's first quest will no longer give any rewards.</li>
      </ul>

      <h4>Balancing</h4>
      <ul class="changelogitem">
        <li>You can now sell the starter weapon pluss a bunch of other items.</li>
        <li>Most of the equipable items can now be traded, not all quest reward items can be traded though.</li>
        <li>Increased XP gained from Young Wolves by 10.</li>
      </ul>
      </div>

      <div class="cont">
          <div class="date">
              2018-03-03 : Patch 1.0.0.5
          </div>
      <h5>Disclaimer: Due to the complexity of this patch and the amount of rebalancing, all characters have been nerfed a little, any level above 15 has been clamped to 15, if you had more than 8000 coins your money have been clamped to 8000.</h5>
      <h4>Code</h4>
      <h5>Core</h5>
          <ul class="changelogitem">
              <li>Added Linux & OSX client support! (Linux server support is in the works!!!)</li>
              <li>Major client & server performance fixes & improvements. Reduced total networking by +40%!</li>
              <li>Changed default tickrate from 66 to 30.</li>
              <li>Added trading, player interaction, level-up panel & more!</li>
              <li>Added cl_debug_raknet and sv_debug_raknet, use these to receive messages regarding data received, handled, etc.</li>
              <li>Added an all new way for handling hit reg + lag compensation, no more expensive lag comp + jittering! Hit detection is much better for players & npcs!</li>
              <li>Updated & optimized the entire database structure.</li>
      </ul>

      <h5>Combat</h5>
      <ul class="changelogitem">
              <li>Fixed missing spell ID link when doing melee, ranged & magic attacks. The damageinfo wouldn't know which spell was used.</li>
              <li>Fixed a bug which would make radius based damage spells ignore other players and even enemies.</li>
              <li>Weapons will now spawn proper decal traces when hitting world / static stuff.</li>
              <li>Added missing lag compensation when casting instant spells or aquiring a target to attack / heal.</li>
              <li>Armor will no longer reduce damage taken if you took magic damage.</li>
              <li>Resistance values will now reduce the damage taken for certain magic schools.</li>
      </ul>

      <h5>Entities</h5>
      <ul class="changelogitem">
              <li>Spell object will now damage/heal properly if it has no creator. (level design placement)</li>
              <li>Spell object will now dispatch damage / heal text properly if the spell has no creator.</li>
              <li>Fixed a crash in the spell_object entity which would occur if the owner of the spell_object suddenly disconnected.</li>
              <li>Fixed spell object not healing teammates.</li>
              <li>item_object's will no longer cast shadows.</li>
              <li>Spell projectiles will only cast shadows if they're ranged projectiles. (arrows)</li>
              <li>Decals should no longer stick on to spell_object, arrow_projectile, spell_projectile and npc_static entities.</li>
              <li>Corpse objects and static npcs will no longer do expensive animation calls when dormant.</li>
              <li>Corpse objects will no longer lose their glow when you reconnect to the game. (if they 'belong' to you)</li>
              <li>Optimized client animation state for npc_static and corpseobject.</li>
              <li>Added prop_dynamic_simple, this is a lightweight, client based animatable entity which should be used instead of prop_dynamic when possible.</li>
      </ul>

      <h5>NPCs</h5>
      <ul class="changelogitem">
              <li>Added resistance attributes for npcs, removed other base stats like Stamina, Strength, etc for now.</li>
              <li>Monsters can now stay put.</li>
              <li>Combatants & Monsters can now patrol properly! You can setup a simple patrol route using path_corners.</li>
      </ul>

      <h5>Players</h5>
      <ul class="changelogitem">
              <li>Fixed a crash which would occur if you tried to fetch reputation info on the server for two players and check if they had certain affiliated reputations.</li>
              <li>Added /promote, you can now promote someone else in your group to become the new group leader.</li>
              <li>You can now /inv, /tell, /kick and /promote in all chat channels except for the whisper channel.</li>
              <li>Added new techniques for calculating the XP needed for a certain lvl, uses simple formulas, the formulas get more complex every 10 lvl.</li>
              <li>You will no longer receive XP when doing low lvl quests, if your lvl is greater than the max quest lvl range.</li>
              <li>Added support for simple testing bots, mostly for profiling work.</li>
              <li>Added the drown bar HUD which indicates how much breath you have, when the bar is empty you will start to take dmg, also
  added threshold values for max breath + damage from drowning.</li>
              <li>No more fade to black when dying due to fall damage.</li>
              <li>You can no longer update/use/equip items while dead.</li>
              <li>Optimized various usermessages.</li>
              <li>Added proper keybinds for zoom in/out @ thirdperson camera.</li>
              <li>Players will now glow when you look at them.</li>
      </ul>

      <h5>GUI & HUD</h5>
      <ul class="changelogitem">
              <li>When reloading client data, all GUI panels and HUD will be refreshed so that the new data pointers will be loaded!</li>
              <li>Item tooltip are now rendered much faster.</li>
              <li>Added missing nav progress UI resource file!</li>
              <li>You will no longer render 3D icons like quest indication icons if you're too far away from the source position.</li>
              <li>Fixed Z position for the actual 3D entity info names and quest icons to use a position vector based on the original position +
  an offset * vecUP direction instead of just adding it directly to the Z component.</li>
              <li>Minimap icons will now render even if the npc_static is dormant.</li>
              <li>Added the quick use item selection HUD! Which allows you to quickly select and use a potion / eat some food. (TAB by default)</li>
              <li>Fixed control sizes @ notification panel for adding friends.</li>
              <li>Fixed slow loading screen code.</li>
              <li>Added a level-up panel which allows the player to choose how much points to spend in Stamina, Agility, Strength & Intellect! You will receive 4 points per level, you can easily reset your points but it will cost money!</li>
              <li>Added the player interaction panel! Simply +use any player to display the menu, it will allow the player to message, invite, inspect or trade with another player.</li>
              <li>Updated the notification panel GUI and scrollbar GUI.</li>
              <li>Fixed a minor bug which would occur when you closed some VGUI panels, the chat would fade in and out quickly.</li>
              <li>You should no longer be able to accidently open up two VGUI menus at the same time if you somehow pressed two buttons at the same time, ex C and P, etc..</li>
              <li>Item tooltips should no longer render outside the screen if ypos is less than 0.</li>
              <li>Increased quest log description font size.</li>
              <li>You can now scroll to the top and bottom @ combat log. (check keyboard options for the bindings)</li>
              <li>The notification panel will now properly send a cancel command when being closed by another panel.</li>
              <li>The Social System GUI will no longer reset the who list whenever it tries to be refreshed.</li>
              <li>Updated the item list height @ Social Panel when searching for other users.</li>
              <li>The social system 'Who list' will no longer add duplicates, also fixed a minor memory leak.</li>
              <li>The 'Who list' search keyword can not be longer than 30 characters!</li>
              <li>The minimap will now render a money icon + the money left, instead of having it as a simple string only.</li>
      </ul>

      <h5>Sound & Music</h5>
      <ul class="changelogitem">
              <li>Music data can now be retrieved faster.</li>
              <li>Reloading client data will now finally reload music data as well.</li>
              <li>FMOD will now be muted if the game is paused or if the game window is inactive while snd_mute_losefocus is set to 1.</li>
      </ul>

      <h4>Maps</h4>
      <h5>Capital Outskirts</h5>
      <ul class="changelogitem">
              <li>Added a new quest, you can pick it up from Commander Felix if you've completed the first smuggler quests.</li>
              <li>Added a new powerful smuggler npc, the npc will patrol around the encampment.</li>
              <li>Added a new npc outside the graveyard catacombs, preparations have started, soon the catacombs will be opened!</li>
              <li>Fixed occluder issues, sometimes wolves would disappear when walking too near the occluders.</li>
              <li>Replaced some areaportal windows with regular areaportals.</li>
      </ul>

      <h4>Balancing</h4>
      <ul class="changelogitem">
              <li>You will no longer have to complete the two starter quests (speak with Rorin + meet up with Felix) in order to pick up other quests, you will now initially start with a simple weapon and be able to pick up any
  available quests from the start!</li>
              <li>Reduced the sell value for multiple items.</li>
      </ul>
      </div>

      <div class="cont">
          <div class="date">
              2017-11-20 : Patch 1.0.0.4
          </div>
          <ul class="changelogitem">
              <li>Major optimization for master, client & server, slow algorithms have been improved greatly.</li>
              <li>All data can now be retrieved super fast, improving the average speed of the game itself.</li>
              <li>ALL VGUI components will now scale 100% perfect when you change resolution!</li>
              <li>Weapon hit detection is now SUPERB, for both players & npcs. Improved melee accuracy!</li>
              <li>Certain items will no longer be precached if they are not present in the map, for example quest items.</li>
              <li>No more precaching of npcs which are not present in the specified map.</li>
              <li>If an NPC is chasing you and you are much further above (Z) the npc, and not visible, then the npc will leave combat and return to spawn.</li>
              <li>The VGUI panels will no longer lag the game, cached all image icons to prevent too much load when opening certain VGUI menus.</li>
              <li>You can now remove spells from the action bar! (by right clicking the spell you want to remove from the bar, spell panel must be open for this to work)</li>
              <li>Fixed VGUI issues like cropped text in merchant window, cropped text in spell panel, if you opened some of the panels fast and closed them fast, wrong fonts would be shown.</li>
              <li>3D Model panel will now render weapons @ the right attachments instead of auto bonemerge.</li>
              <li>Fixed tooltips for Character Stats and Character Reputation disappearing if you opened the Reputation tab and hovered over a reputation item and then went back to the Stats tab, this prevented the stats from rendering tooltips.</li>
              <li>The notification panel can now be properly closed by pressing ESC, previously it would not add the mainmenu prevention when it re-opened friends or character panel.</li>
              <li>Fixed a bad bug which would occur when looking for available inventory slot(s), in some cases when you looked for a slot you could pick the same slot twice, and add an item 'above' an existing item.</li>
              <li>The Avatar model HUD will now update properly when you change equipment.</li>
              <li>Moved the quest tracking HUD a bit more to the left, to line up with the minimap.</li>
              <li>Fixed a potential bug which would occur when playerID > greater than 16 bits. (playerID & groupID is now 21 bits instead)</li>
              <li>Rewrote the weapon logic, all hit detection related stuff is done on the server, the model only exists on the client! (for players and npcs)   also saved network edicts, + server load, due to the fact that the weapons followed the entity on the client + server...</li>
              <li>Fixed some issues related to dual wielding.</li>
              <li>You can now set model scale for NPC @ npc scripts.</li>
              <li>NPC loot drop percentages are now represented as float, which is convenient for items with a super low percentage.</li>
              <li>Fixed a bug which would occur in dungeons if Steam didn't load properly, the dungeon would report to the master before connecting to the master.</li>
              <li>Added player deletion group handling, if the deleted player were in a group, announce and handle this properly.</li>
              <li>Added name character limit, people shouldn't be allowed to have extremely long names! (limited to 16 characters)</li>
              <li>Added a simple combat log HUD which displays damage taken, damage dealt, healing, etc... (check keyboard bindings for scrolling up & down)</li>
              <li>Added simple death punishment, from now on you will lose 10% of your money when dying.</li>
              <li>Added a new spell entity : spell_object which is a spell that spawns on the ground and renders a fancy texture effect on the ground, anyone who enters this volume (bounds) will be affected by this spell.</li>
              <li>NPCs can now flee properly, added proper NavMesh support.</li>
              <li>Fixed faulty networked variables, some sent too few / many bits.</li>
              <li>Added support for PvP when PvP mode is enabled! (group up to prevent friendly fire...)</li>
              <li>Updated the drop rate for some items, the cost/sell values for food and other valuable items.</li>
              <li>Improved local devmode functionality.</li>
          </ul>
      </div>

      <div class="cont">
          <div class="date">
              2017-10-01 : Patch 1.0.0.3
          </div>
          <ul class="changelogitem">
              <li>Guards will no longer try to flee when at low health.</li>
              <li>Changed cooldown rendering to be more obvious.</li>
              <li>Fixed fake loading screen for dungeon system, the fake loading screen is opened while waiting for the dungeon to
                  start.
              </li>
              <li>Fixed reputation bugs, if you reached max rep it would reset back from 0 next time you received rep. Also, getting
                  negative rep while at max rep wouldn't have changed your rep value.</li>
              <li>No more health regen while taking poison, drown & fall damage.</li>
              <li>Vital data will now save every 60 sec, previously your vital data such as XP needed/current, level, etc would only
                  save when you disconnected. Now, if the server crashed that wouldn't happen = lost data!</li>
              <li>Added proper crash handling for dungeon and world servers, players will not be left online forever if they don't
                  reconnect to the game after being dropped from a crashed server.</li>
              <li>Fixed a bug which would set everyone to 'offline' in the database whenever the master restarted. (when crashed)</li>
              <li>Optimized data sent & received via master app.</li>
          </ul>
      </div>

      <div class="cont">
          <div class="date">
              2017-09-14 : Patch 1.0.0.2 Hotfix 2
          </div>
          <ul class="changelogitem">
              <li>Fixed a major bug which would reset your client data and cause packet loss when connecting with your selected character.</li>
              <li>You can no longer +use spam on doors, each +use will create a 2 second penalty.</li>
              <li>Added new voice communication icons.</li>
              <li>A voice icon will now be rendered for the local player as well, whenever the local player is communicating via voice.</li>
          </ul>
      </div>

      <div class="cont">
          <div class="date">
              2017-09-10 : Patch 1.0.0.2 Hotfix 1
          </div>
          <ul class="changelogitem">
              <li>Fixed a crash issue related to data received for both client & server.</li>
              <li>Fixed issues related to item tooltips not refreshing when moving items, swapping items, etc...</li>
          </ul>
      </div>

      <div class="cont">
          <div class="date">
              2017-09-10 : Patch 1.0.0.2
          </div>
          <h4>Code:</h4>
          <ul class="changelogitem">
              <li>If you have the required items for a quest you just picked up, those objectives will now be progressed right away.</li>
              <li>Optimized various calls to remove and add @ inventory items.</li>
              <li>Handing in a quest will now remove all related quest items, regardless if they're in your bank or not.</li>
              <li>Fixed issues which would make incoming packets handled in an anti-queue manner.</li>
              <li>If you have multiple quests which require the same item, handing in one of those quests will remove all of the desired
                  item(s), and remove progress from other quests who also needed these items.</li>
              <li>If a quest has no rewards or objectives, these parts will no longer be rendered.</li>
              <li>When a player takes damage, health regen will be delayed for 750 msec.</li>
              <li>Dungeon system has been fully reworked, and will be introduced in the next patch, most likely!</li>
              <li>Increased quest description font size + changed the font itself.</li>
              <li>Changed quest reward info font and font size as well.</li>
              <li>Fixed an issue in the quest panel where the reward text would clip with other text.</li>
              <li>The action bars will now draw the keybind instead of numbers between 1-8, the action bars are tied to slot1-slot8.</li>
              <li>Mayor Rorin's 3D model position @ 2D info panel has been fixed.</li>
              <li>Fixed issues related to gameservers not fully reconnecting to the master server during connection issues.</li>
              <li>Optimized the master server app, fixed bogus addressing.</li>
          </ul>

          <h4>Balancing:</h4>
          <ul class="changelogitem">
              <li>Nerfed the two handed swords found in Capital Outskirts.</li>
              <li>Nerfed the one handed maces found in Capital Outskirts.</li>
              <li>Reduced sell price of food consumeables.</li>
              <li>Added missing quantity for food items, when you purchase food you'll purchase it in quantities of 5 instead of 1.</li>
          </ul>

          <h4>Capital Outskirts:</h4>
          <ul class="changelogitem">
              <li>Added some clips to prevent players from getting stuck.</li>
              <li>Added an npc clip at the house near the bandit camp to prevent the npcs from getting stuck on the stairs.</li>
              <li>Added clip @ stairs so that walking on stairs won't make you jitter.</li>
              <li>Removed unnecessary entities.</li>
              <li>Made some changes to the optimization in the map, the networking traffic has been lowered by 50%+!</li>
          </ul>

          <h4>Lobby:</h4>
          <ul class="changelogitem">
              <li>Removed unnecessary entities.</li>
              <li>Made some changes to the optimization in the map, the networking traffic has been lowered by 50%+!</li>
          </ul>
      </div>

      <div class="cont">
          <div class="date">
              2017-08-27 : Patch 1.0.0.1
          </div>
          <ul class="changelogitem">
              <li>Fixed some typos in the scripts.</li>
              <li>All scripts can now be reloaded on the server & client.</li>
              <li>Friend items will no longer show N/A when friends go offline.</li>
              <li>Added logic_bank_handler, which handles bank access stuff.</li>
              <li>Added logic_changelevel which can be used to trigger changelevel through npc interaction for example.</li>
              <li>Added the last pieces of the banking system.</li>
              <li>Added tooltip info for reputation entries. Now you can read helpful information about your reputations!</li>
              <li>HP and focus will be restored on level-up.</li>
              <li>Fixed armor not following the owner properly when the owner went out of the local player's PVS, also added missing
                  skin and bodygroup support.</li>
              <li>Fixed a bug which allowed players to pick up more item_objects than the quest required, for quests which had multiple
                  objectives. Example: You could pick up 6 pumpkins, when you only needed 5.</li>
              <li>NPCs HP regen will be delayed for 0.5 sec when not in combat and taking damage, sometimes if you attacked an NPC
                  and the NPC didn't see you at first, the npc would regen the HP lost.</li>
              <li>Fixed a bug which made the spellcast bar display the wrong cast time.</li>
              <li>Fixed bad memory bug @ server, npc auto respawning logic.</li>
              <li>You will now know if you're sending a message to the Global, Local or Party chat channel.</li>
              <li>Projectile based spells will now take your spell power into account when computing the damage.</li>
              <li>Projectile spells and arrows will no longer bounce, they will also auto remove when hitting any solid object.</li>
              <li>Projectile spells and arrows will now automatically increase gravity affection when travelling further than the effective
                  range.</li>
              <li>If you're in a group, and someone in your group has a quest which requires a certain item which drops from certain
                  NPCs, only those people with the quest will be able to loot these items!</li>
              <li>A confirmation window will now appear when you try to delete one of your users.</li>
              <li>Delay items will no longer be lost when a gameserver restarts or when a dungeon is created.</li>
              <li>NPCs further away than 800 units from the attacker (player), will no longer be lagcompensated.</li>
              <li>Quest reward logic has been simplified, you will now be properly notified if you are to choose or receive all of
                  the rewards for a certain quest.</li>
              <li>Fixed a major issue related to the master server, if it crashed, gameserver would not reconnect to the newly restarted
                  master.</li>
              <li>Fixed player minimap icons being super tiny.</li>
              <li>Added minimap icons for merchants, bankers, quests available and quest handin, so that players can get proper hints!
                  You can disable these minimap icons by setting: overview_hinticons to 0!</li>
              <li>Various client performance improvements.</li>
          </ul>
      </div>

      <div class="cont">
          <div class="date">
              2017-08-17 : Infestus Beta 1
          </div>
          <h4>Infestus Beta 1 has been released!</h4>
      </div>
  </v-container>
</template>

<script>
export default {
  name: "ChangelogView",
  mounted() {
    window.scrollTo(0, 0)
  },
}
</script>

<style scoped>
@import url('https://fonts.googleapis.com/css?family=Encode+Sans+Expanded');

* {
  font-family: 'Encode Sans Expanded', sans-serif;
}

html,
body,
div {
  padding: 0px;
  margin: 0px;
}

body {
  background-color: #1e1e1e;
  color: white;
  text-shadow: 0px 0px 2px black;
  overflow-x: hidden;
}

.cont {
  margin-top: 10px;
  margin-left: 10px;
  margin-bottom: 25px;
  padding-bottom: 10px;
  border-bottom: 1px solid #ffffff;
  position: relative;
}

.date {
  font-size: 1em;
  color: white;
  margin-bottom: 8px;
  font-weight: bolder;
}

.changelogitem {
  list-style: square;
  font-size: 0.8em;
  padding-left: 35px;
}

h4 {
  margin-bottom: 0px;
}

h5 {
  margin: 8px;
}
</style>
