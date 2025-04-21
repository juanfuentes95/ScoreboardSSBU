# ScoreboardSSBU

Smash Bros. Ultimate's Scoreboard for Streamlabs OBS (C#).

## Usage

1. Extract [Lastest Version](https://github.com/juanfuentes95/ScoreboardSSBU/releases/latest) on any location.
1. (Optional) Add player in "PlayersDatabase.txt" to autocomplete names.
2. Link to Streamlabs OBS:
	
🎮 Player `<number>`
* IconPlayer`<number>`.png -> Icon of selected character
* NamePlayer`<number>`.txt -> Nick
* PortraitPlayer`<number>`.png -> Portrait of selected character
* RegionPlayer`<number>`.txt -> Region/country
* ScorePlayer`<number>`.txt -> Score
* SeedPlayer`<number>`.txt -> Seed of player
* SocialNetPlayer`<number>`.txt -> format of (socialnet | user)
* SocialNetPlayer`<number>`.png -> Social network image (instagram/twitter/facebook)\*
* SocialNetPlayer`<number>`\_user.txt -> user
* TeamPlayer`<number>`.txt -> not used at the moment

🎙️ Caster `<number>`
* NameCaster`<number>`.txt -> Nick
* SocialNetCaster`<number>`.txt -> format of (socialnet | user)
* SocialNetCaster`<number>`.png -> Social network image (instagram/twitter/facebook)\*
* SocialNetCaster`<number>`\_user.txt -> user

\* you can add your own social network of 500x500 pixels inside "SocialnetIcon" folder

🧾 Others 
* tournament_name.txt -> Tournament name textbox
* tournament_information.txt -> Tournament information textbox  

## Contributing

Pull requests are welcome. Please make sure to update tests as appropriate.

## Licensing

ScoreboardSSBU is licensed under the Apache License, Version 2.0. See [LICENSE](https://github.com/juanfuentes95/ScoreboardSSBU/blob/master/LICENSE) for the full license text.
