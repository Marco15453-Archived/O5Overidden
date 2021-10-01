# O5 Overidden
A simple Exiled Plugin that allows the O5 Keycard to override Specific DoorLockTypes

# Types
You can see all types [here](https://github.com/Marco15453/O5Overidden/blob/master/TYPES.md)

# Config
Name | Type | Description | Default
---- | ---- | ----------- | -------
is_enabled | bool | hould the plugin be enabled? | true
cooldown | int | Cooldown for the O5 Overidden (-1 = Disabled) | 30
cooldown_message | string | Cooldown Message | <color=red>You need to wait %COOLDOWN% seconds before you can overide an door again
overriden_message | string | The message that will be displayed when a player successfully overidden an door (Empty = Disabled) | <color=blue>You overidden the Door, It has been unlocked
affected_lock_types | HashSet | What DoorLockTypes should the O5 Override? | Lockdown079, Regular079
blacklisted_doors | HashSet | Blacklisted Doors | Scp106Bottom, Scp106Primary, Scp106Secondary

# Default Config
```yml
o5_overidden:
  # Should the plugin be enabled?
  is_enabled: true
  # Cooldown for the O5 Overidden (-1 = Disabled)
  cooldown: 30
  # Cooldown Message
  cooldown_message: <color=red>You need to wait %COOLDOWN% seconds before you can overide an door again
  # The message that will be displayed when a player successfully overidden an door (Empty = Disabled)
  overriden_message: <color=blue>You overidden the Door, It has been unlocked
  # What DoorLockTypes should the O5 Override?
  affected_lock_types:
  - Lockdown079
  - Regular079
  # Blacklisted Doors
  blacklisted_doors:
  - Scp106Bottom
  - Scp106Primary
  - Scp106Secondary
```