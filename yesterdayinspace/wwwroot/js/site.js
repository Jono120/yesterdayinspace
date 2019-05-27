// Please see documentation at https://docs.microsoft.com/aspnet/core/client-side/bundling-and-minification
// for details on configuring this project to bundle and minify static web assets.

// These were originally going to be used for everything, but
// now I'm just relegating it to the Gallery
const local = "/";
const remote = "https://www.lga.nz:40443/services/STPYIS/remote/";

// We only want to show the products, reviews, and music after YIS is finished (21st March 2019)
const afterDateS = "21 Mar 2019";
const afterDate = new Date(afterDateS); // Convert our date to a date object
const today = new Date(); // Get today's date

// Shamelessly taken from librarium-sqlite
$(document).ready(function() {
	// If we are launched standalone (i.e. in web-app mode), add
	// a class to our body element to add some extra space to the
	// navigation bar/header
	if (window.navigator.standalone == true) {
		$('body').addClass('webapp');
	}
    // We can basically use this code on any circle-section as
    // the attributes are mostly the same. Checks are done in showBio()
    $(".yis-circlesect").on("click","li", function(event){
        event.preventDefault();
        var id = $(this).attr('data-id');
        getEntity(id);
        $('#YIS-BioPane').fadeIn();
	});

	if(afterDate <= today) {
		// Show Music in the navbar
		$("ul.navbar-nav").append('<li><a href="/Music">Music</a></li>');
		// Redirect the Book Now button on the home page
		$("body.home button.btn-primary").attr("onclick","window.location='/ShipLaunched'");
	}
});

function getEntity(id) {

    var url = '/GetCC';

    var query = {id: id};
    
    $.getJSON(url, query)
        .done(function(json) {
            $.each( json, function( key, val ) {
                // Pull data from the JSON into shorter variables
                var name = json["name"];
				var role = json["role"];
				var altrole = json["altRole"];
                var img = json["bioImg"];
				var bio = json["bioText"];
				
				var s1t = json["social1Type"];
				var s1u = json["social1URL"];
				var s1d = json["social1Display"];
				var s2t = json["social2Type"];
				var s2u = json["social2URL"];
				var s2d = json["social2Display"];
				var s3t = json["social3Type"];
				var s3u = json["social3URL"];
				var s3d = json["social3Display"];
				var s4t = json["social4Type"];
				var s4u = json["social4URL"];
				var s4d = json["social4Display"];
				var s5t = json["social5Type"];
				var s5u = json["social5URL"];
				var s5d = json["social5Display"];

                fn = "<b>" + name + "</b>";

				if(role) { fn = fn + "<br />" + role; }
				if(altrole) { fn = fn + "<br /><span class='altrole'>" + altrole + "</span>"; }

				var social = "";
				if(s1t != "none" && s1t != null) { social+= "<li><a href='" + s1u + "'>" + sicon(s1t) + s1d + "</a></li>" }
				if(s2t != "none" && s2t != null) { social+= "<li><a href='" + s2u + "'>" + sicon(s2t) + s2d + "</a></li>" }
				if(s3t != "none" && s3t != null) { social+= "<li><a href='" + s3u + "'>" + sicon(s3t) + s3d + "</a></li>" }
				if(s4t != "none" && s4t != null) { social+= "<li><a href='" + s4u + "'>" + sicon(s4t) + s4d + "</a></li>" }
				if(s5t != "none" && s5t != null) { social+= "<li><a href='" + s5u + "'>" + sicon(s5t) + s5d + "</a></li>" }

                $('#YIS-BioFullImg').attr('src', img);
                $('#YIS-BioName').html(fn);
				$('#YIS-BioInfoText').html(bio);
				$('#YIS-BioInfoSocial').html(social);
            });
		})
		.fail(function(json) {
            alert("Sorry, we're having problems retrieving the Cast, Crew, and Characters data. Please try again later.");
		});
}

function sicon(type) {
	var svg;
	switch (type) {
		case 'facebook':
			svg = '<svg viewBox="0 0 257.71679 257.71876" style="width: 20px; height: 20px; vertical-align: middle; fill: currentColor; margin-right: 5px;" xmlns="http://www.w3.org/2000/svg"><use xlink:href="/images/biolinks/facebook.svg#Blue_1_"></use></svg>';
			break;

		case 'instagram':
			svg = '<svg viewBox="0 0 95.999002 96" style="width: 20px; height: 20px; vertical-align: middle; fill: currentColor; margin-right: 5px;" xmlns="http://www.w3.org/2000/svg"><use xlink:href="/images/biolinks/instagram.svg#path4177"></use></svg>';
			break;

		case 'twitter':
			svg = '<svg viewBox="0 0 250 250" style="width: 20px; height: 20px; vertical-align: middle; fill: currentColor; margin-right: 5px;" xmlns="http://www.w3.org/2000/svg"><use xlink:href="/images/biolinks/twitter.svg#path10"></use></svg>';
			break;

		case 'starnow':
			svg = '<svg viewBox="0 0 100 100" style="width: 20px; height: 20px; vertical-align: middle; fill: currentColor; margin-right: 5px;" xmlns="http://www.w3.org/2000/svg"><use xlink:href="/images/biolinks/starnow.svg#path22"></use></svg>';
			break;

		case 'tumblr':
			svg = '<svg viewBox="0 0 160.00001 160" style="width: 20px; height: 20px; vertical-align: middle; fill: currentColor; margin-right: 5px;" xmlns="http://www.w3.org/2000/svg"><use xlink:href="/images/biolinks/tumblr.svg#path78"></use></svg>';
			break;

		case 'wellingtonista':
			svg = '<svg viewBox="0 0 52.916665 52.916668" style="width: 20px; height: 20px; vertical-align: middle; fill: currentColor; margin-right: 5px;" xmlns="http://www.w3.org/2000/svg"><use xlink:href="/images/biolinks/wellingtonista.svg#layer1"></use></svg>';
			break;

		case 'linkedin':
			svg = '<svg viewBox="0 0 36 36" style="width: 20px; height: 20px; vertical-align: middle; fill: currentColor; margin-right: 5px;" xmlns="http://www.w3.org/2000/svg"><use xlink:href="/images/biolinks/linkedin.svg#path26"></use></svg>';
			break;

		case 'behance':
			svg = '<svg viewBox="0 0 599.99999 600" style="width: 20px; height: 20px; vertical-align: middle; fill: currentColor; margin-right: 5px;" xmlns="http://www.w3.org/2000/svg"><use xlink:href="/images/biolinks/behance.svg#rect23"></use></svg>';
			break;

		case 'github':
			svg = '<svg viewBox="0 0 11.493064 11.209466" style="width: 20px; height: 20px; vertical-align: middle; fill: currentColor; margin-right: 5px;" xmlns="http://www.w3.org/2000/svg"><use xlink:href="/images/biolinks/github.svg#path102"></use></svg>';
			break;

		case 'soundcloud':
			svg = '<svg viewBox="0 0 11.493064 11.209466" style="width: 20px; height: 20px; vertical-align: middle; fill: currentColor; margin-right: 5px;" xmlns="http://www.w3.org/2000/svg"><use xlink:href="/images/biolinks/soundcloud.svg#path15"></use></svg>';
			break;

		case 'youtube':
			svg = '<svg viewBox="0 0 121.4009 85" style="width: 20px; height: 20px; vertical-align: middle; fill: currentColor; margin-right: 5px;" xmlns="http://www.w3.org/2000/svg"><use xlink:href="/images/biolinks/youtube.svg#path4732"></use></svg>';
			break;

		case 'web':
			svg = '<svg viewBox="0 0 20 20" style="width: 20px; height: 20px; vertical-align: middle; fill: currentColor; margin-right: 5px;" xmlns="http://www.w3.org/2000/svg"><use xlink:href="/images/biolinks/web.svg#path4756"></use></svg>';
			break;

		case 'artstation':
			svg = '<svg viewBox="0 0 11.493064 11.209466" style="width: 20px; height: 20px; vertical-align: middle; fill: currentColor; margin-right: 5px;" xmlns="http://www.w3.org/2000/svg"><use xlink:href="/images/biolinks/artstation.svg#path4"></use></svg>';
			break;
	
		default:
			break;
	}
	return svg;
}

function listCC() {

    var url = '/GetEntity';

    var query = {};
    
    $.getJSON(url, query)
        .done(function(json) {
            $.each( json, function( key, val ) {
                // Pull data from the JSON into shorter variables
                var name = json[key]["name"];
				var role = json[key]["role"];
				var altrole = json[key]["altrole"];
                var img = json[key]["bioimg"];
                var bio = json[key]["bio"];

                fn = "<b>" + name + "</b>";

				if(role) { fn = fn + "<br />" + role; }
				if(altrole) { fn = fn + "<br />" + altrole; }

                $('#YIS-BioFullImg').attr('src', img);
                $('#YIS-BioName').html(fn);
                $('#YIS-BioInfo').html(bio);
            });
		})
		.fail(function(json) {
            alert("Sorry, we're having problems retrieving the Cast & Crew data. Please try again later.");
		});
}

function getGallery(location) {

    var url = location + 'GetGallery';

    var query = {};

    $.getJSON(url, query)
        .done(function(json) {
			var gpImages = [];
			gpiTitle = "<h2>Images</h2>"
			gpImages.push(gpiTitle);
			var gpReviews = [];
			gprTitle = "<h2>Reviews</h2>"
			gpReviews.push(gprTitle);
			var gpProducts = [];
			gppTitle = "<h2>Products</h2>"
			gpProducts.push(gppTitle);
			var gpVideos = [];
			gpvTitle = "<h2>Videos</h2>"
			gpVideos.push(gpvTitle);
            $.each( json, function( key, val ) {
                // Pull data from the JSON into shorter variables
                var thumburl = json[key]["thumbURL"];
				var url = json[key]["url"];
				var caption = json[key]["caption"];
				var type = json[key]["type"];

				switch (type) {
					case 'image':
						gpImage = "<a href='" + url + "' data-fancybox='images' data-caption='" + caption + "' title='" + caption + "'>" +
						"<img src='" + thumburl + "' /></a>";
						gpImages.push(gpImage);
						break;

					case 'review':
						gpReview = "<a href='" + url + "' data-fancybox='reviews' data-caption='" + caption + "' title='" + caption + "'>" +
						"<img src='" + thumburl + "' /></a>";
						gpReviews.push(gpReview);
						break;

					case 'product':
						gpProduct = "<a href='" + url + "' data-fancybox='products' data-caption='" + caption + "' title='" + caption + "'>" +
						"<img src='" + thumburl + "' /></a>";
						gpProducts.push(gpProduct);
						break;

					case 'video':
						gpVideo = "<a href='" + url + "' data-fancybox='videos' data-caption='" + caption + "' title='" + caption + "'>" +
						"<img src='" + thumburl + "' /></a>";
						gpVideos.push(gpVideo);
						break;
				
					default:
						break;
				}
			});

			$('#GPImages').html(gpImages.join( "" ));
			if(afterDate <= today) {
				$('#GPReviews').html(gpReviews.join( "" ));
				$('#GPReviews').show();
				$('#GPProducts').html(gpProducts.join( "" ));
				$('#GPProducts').show();
			}
			$('#GPVideos').html(gpVideos.join( "" ));
		})
		.fail(function(json) {
			getGallery(local);
			alert("Sorry, we're having problems connecting to the remote server for the latest Gallery data. Local data has been loaded instead");
		});
}

function getMusic(location) {

    var url = location + 'GetMusic';

    var query = {};

    $.getJSON(url, query)
        .done(function(json) {
			var items = [];
            $.each( json, function( key, val ) {
                // Pull data from the JSON into shorter variables
                var ti = json[key]["title"];
				var em = json[key]["embed"];
				var bc = json[key]["bandURL"];
				var sc = json[key]["soundURL"];
				var nf = json[key]["info"];

				item = "<div class='mpItem'>" +
						"<h2>" + ti + "</h2>" +
						"<iframe width='100%' height='166' scrolling='no' frameborder='no' allow='autoplay' src='https://w.soundcloud.com/player/?url=https%3A//api.soundcloud.com/tracks/" + em + "&color=%23420264&auto_play=false&hide_related=false&show_comments=true&show_user=true&show_reposts=false&show_teaser=true'></iframe>" +
						"<ul class='mpLinks'><li><a href='" + sc + "'>Listen on SoundCloud</a></li><li><a href='" + bc + "'>Listen on BandCamp</a></li></ul>" +
						"<div class='mpInfo'>" + nf + "</div>" + 
						"</div>";
				items.push(item);
						
			});

			$('#MPList').html(items.join( "" ));
		})
		.fail(function(json) {
			getMusic(local);
			alert("Sorry, we're having problems connecting to the remote server for the latest Music data. Local data has been loaded instead");
		});
}