fetch("../sitecluster.json")
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
                iconUrl: 'imgs/MarkerIcon.jpg',
                iconSize: [18, 18],
                shadowSize: [41, 41],
                iconAnchor: [12, 41],
                popupAnchor: [0, -41],
                button: onclick = console.log,

            });
            var marker = L.marker([site.lat, site.lon], { icon: myIcon });
            markers.addLayer(marker);

        }
        markers.addTo(map);
    });

