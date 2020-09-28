### <u>API Requests: Endpoints</u>

Ordinary users can do Get-requests by using the web page interface. Post, put and delete is reserved for admin users and will only be accessible through backend use as of right now. I have an idea to add a admin page to the website in the future where these requests will be available to admin users.



###### Get examples:

MAJOR CHORD -> GET: `scapi/v1.0/Chord/C` (Gets the C major chord)

MINOR CHORD -> GET: `scapi/v1.0/Chord/C&TriadType=Minor` (Gets the C minor chord)

DIMINISHED CHORD -> GET: `scapi/v1.0/Chord/C&TriadType=Dim` (Gets the C diminished chord)

AUGMENTED CHORD -> GET: `scapi/v1.0/Chord/C&TriadType=Aug` (Gets the C augmented chord)

COLORED CHORD -> GET: `scapi/v1.0/Chord/C#&TriadType=Minor&Coloration=7` (Gets the C#m7 chord)

​			Note that the input of the Coloration is a string and not an int. 

​			This is to allow for pitches in color-notes. For example the major 7th would be written "maj7".



###### Post example:

Posts are done in json-format and would look like this (Illustrated: post of Cmaj7, fifth string):

POST: `scapi/v1.0/Chord/`

BODY: 

```
{
	"BaseNote": "C"
	"FretPosition": 3
	"StartString": 5
	"TriadType": "Major"
	"ColorNote": "maj7"
	"ChordDiagram": 
    {
    	"Picture": [Path to where chord diagram picture is stored]" 
    }
}
```



###### Put example:

Again these are done in json-format. Put in the URL of the chord you wish to update and supply the json file:

PUT: `scapi/v1.0/Chord/C#&TriadType=Major&Coloration=maj7`

BODY: 

```
{
	"BaseNote": "C#"
	"FretPosition": 4
	"StartString": 5
	"TriadType": "Major"
	"ColorNote": "maj7"
	"ChordDiagram": 
    {
    	"Picture": [Path to where chord diagram picture is stored]" 
    }
}
```

The body here is only as an example, one could change anything here and it would be updated.



###### Delete example:

Deletes can be done with either the URL to a specific chord or with an ID:

DELETE: `scapi/v1.0/Chord/C#&TriadType=Major&Coloration=maj7` (Deletes the Cmaj7 chord)

DELETE: `scapi/v1.0/Chord/10` (Deletes the same chord (not sure if ID will be correct in the future but you get the point)) 

