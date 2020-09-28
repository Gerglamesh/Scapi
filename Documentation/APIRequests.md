### <u>API Requests: Endpoints</u>

###### Get examples:

MAJOR CHORD -> GET: `scapi/v1.0/Chord/C` (Gets the C major chord)

MINOR CHORD -> GET: `scapi/v1.0/Chord/C&TriadType=Minor` (Gets the C minor chord)

DIMINISHED CHORD -> GET: `scapi/v1.0/Chord/C&TriadType=Dim` (Gets the C diminished chord)

AUGMENTED CHORD -> GET: `scapi/v1.0/Chord/C&TriadType=Aug` (Gets the C augmented chord)

COLORED CHORD -> GET: `scapi/v1.0/Chord/Minor/C#&TriadType=Minor&Coloration=7` (Gets the C#m7 chord)

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

