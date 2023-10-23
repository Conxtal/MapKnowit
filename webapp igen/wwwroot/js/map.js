fetch("Data/sitecluster.json")
    .then(response => response.json())
    .then(data => {
        var map = L.map('map').setView([59.3789291381836, 16.4947643280029], 7);

        L.tileLayer('https://{s}.tile.openstreetmap.org/{z}/{x}/{y}.png', {
            attribution: 'map data &copy; <a href="https://www.openstreetmap.org/">OpenStreetMap</a> contributors',
            maxZoom: 18,
            minZoom: 3
        }).addTo(map);

        var filtredSites = data.Locations; 

        var markers = L.markerClusterGroup();

        for (var i = 0; i < filtredSites.length; i++) { 
            var site = filtredSites[i]; 

            var myIcon = L.icon({ 
                iconUrl: 'imgs/MarkerIcon.png',
                iconSize: [18, 18],
                shadowSize: [41, 41],
                iconAnchor: [12, 41],
                popupAnchor: [0, -41]
            });
            var marker = L.marker([site.lat, site.lon], { icon: myIcon }).addTo(map);
            markers.addLayer(marker);
        }

        map.addLayer(markers); // Add the markers layer to the map
    });

function myIcon('imgs/MarkerIcon.png') {
        var infobox = document.getElementById("myInfobox");
        infobox.classList.toggle("show");
}

function myIcon .search() {
    while (Write = 'Data/sitecluster.json') {
        var keyboardEvent = document.createEvent('KeyboardEvent'); 
        var initMethod = typeof keyboardEvent.initKeyboardEvent !== 'undefined' ? 'initKeyboardEvent' : 'initKeyEvent'; 
        keyboardEvent[initMethod]('keydown', // event type : keydown, keyup, keypress
             true, // bubbles
             true, // cancelable
             window, // viewArg: should be window
             false, // ctrlKeyArg
             false, // altKeyArg
             false, // shiftKeyArg
             false, // metaKeyArg
             13, // keyCodeArg : unsigned long the virtual key code, else 0
             13 // charCodeArgs : unsigned long the Unicode character associated with the depressed key, else 0
        );
        document.getElementById('text').dispatchEvent(keyboardEvent);
        var infobox = document.getElementById("myInfobox");
        infobox.classList.toggle("show");
    }
}