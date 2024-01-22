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

            // importerar data för att skapa ett pop up ruta när du har musen över en marker
            marker.on('mouseover', function () {
               
                marker.bindPopup(`
                    <strong>Address:</strong> ${site.display_name} <br>
                    <strong>Road:</strong> ${site.address.road} <br>
                    <strong>Village:</strong> ${site.address.village} <br>
                    <strong>City district:</strong> ${site.address.city_district} <br>
                    <strong>City:</strong> ${site.address.city} <br>
                    <strong>State:</strong> ${site.address.state} <br>
                    <strong>Region:</strong> ${site.address.region} <br>
                    <strong>Country:</strong> ${site.address.country} <br>
                    <strong>Country code:</strong> ${site.address.country_code} <br>
                    <strong>Town:</strong> ${site.address.town} <br>
                    <strong>County:</strong> ${site.address.county} <br>
                    <strong>addresstype:</strong> ${site.addresstype} <br>
                `).openPopup();
               
            });
            marker.on('click', function () {
                var item = document.getElementById('infoboxBackground');
                console.log(item);
                item.style.visibility = 'visible';
                document.getElementById('latitude').innerHTML = (`<strong>Latitude:</strong> ${site.lat}`)
                document.getElementById('longitude').innerHTML = (`<strong>Longitude:</strong> ${site.lon}`)
                document.getElementById('display_name').innerHTML = (`<strong>Address:</strong> ${site.display_name}`)
                document.getElementById('road').innerHTML = (`<strong>Road:</strong> ${site.address.road}`)
                document.getElementById('village').innerHTML = (`<strong>Village:</strong> ${site.address.village}`)
                document.getElementById('isolated_dwelling').innerHTML = (`<strong>Isolated dwelling:</strong> ${site.address.isolated_dwelling}`)
                document.getElementById('municipality').innerHTML = (`<strong>Municipality:</strong> ${site.address.municipality}`)
                document.getElementById('city_district').innerHTML = (`<strong>City district:</strong> ${site.address.city_district}`)
                document.getElementById('city').innerHTML = (`<strong>City:</strong> ${site.address.city}`)
                document.getElementById('state').innerHTML = (`<strong>State:</strong> ${site.address.state}`)
                document.getElementById('ISO3166-2-lvl4').innerHTML = (`<strong>ISO3166 2 lvl4:</strong> ${site.address.lvl4}`)
                document.getElementById('region').innerHTML = (`<strong>Region:</strong> ${site.address.region}`)
                document.getElementById('ISO3166-2-lvl3').innerHTML = (`<strong>ISO3166 2 lvl3:</strong> ${site.address.lvl3}`)
                document.getElementById('postcode').innerHTML = (`<strong>Postcode:</strong> ${site.address.postcode}`)
                document.getElementById('country').innerHTML = (`<strong>Country:</strong> ${site.address.country}`)
                document.getElementById('country_code').innerHTML = (`<strong>Country code:</strong> ${site.address.country_code}`)
                document.getElementById('town').innerHTML = (`<strong>Town:</strong> ${site.address.town}`)
                document.getElementById('county').innerHTML = (`<strong>County:</strong> ${site.address.county}`)
                document.getElementById('ResponseCode').innerHTML = (`<strong>Response Code:</strong> ${site.ResponseCode}`)
                document.getElementById('addresstype').innerHTML = (`<strong>Address type:</strong> ${site.addresstype}`)
                
                map.on('click', function () {
                    var item = document.getElementById('infoboxBackground');
                    console.log(item);
                    item.style.visibility = 'hidden'

                   
                });
              
                
            });

            markers.addLayer(marker);
        });

        markers.addTo(map);
        
    });

