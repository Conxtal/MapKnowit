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

        filtredSites.forEach(site => {
            var myIcon = L.icon({
                iconUrl: 'imgs/MarkerIcon.jpg',
                iconSize: [18, 18],
                shadowSize: [41, 41],
                iconAnchor: [12, 41],
                popupAnchor: [0, -41],
            });

            var marker = L.marker([site.lat, site.lon], { icon: myIcon });

            // Use a function to dynamically generate the popup content based on JSON data
            marker.bindPopup(function () {
                return `
                    <strong>Latitude :</strong> ${site.lat}<br>
                    <strong>Longitude :</strong> ${site.lon}<br>
                    <strong>Address :</strong> ${site.display_name} <br>
                    <strong>Road :</strong> ${site.address.road} <br>
                    <strong>Village :</strong> ${site.address.village} <br>
                    <strong>Isolated dwelling :</strong> ${site.address.isolated_dwelling} <br>
                    <strong>Municipality :</strong> ${site.address.municipality} <br>
                    <strong>City district :</strong> ${site.address.city_district} <br>
                    <strong>City :</strong> ${site.address.city} <br>
                    <strong>State :</strong> ${site.address.state} <br>
                    <strong>Region :</strong> ${site.address.region} <br>
                    <strong>Postcode :</strong> ${site.address.postcode} <br>
                    <strong>Country :</strong> ${site.address.country} <br>
                    <strong>Country code :</strong> ${site.address.country_code} <br>
                    <strong>Town :</strong> ${site.address.town} <br>
                    <strong>County :</strong> ${site.address.county} <br>
                    <strong>ResponseCode :</strong> ${site.ResponseCode} <br>
                    <strong>addresstype :</strong> ${site.addresstype} <br>

                   `;
            });

            markers.addLayer(marker);
        });

        markers.addTo(map);
    });
