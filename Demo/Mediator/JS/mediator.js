// Players
function Player(name) {
	this.points = 0;
	this.name = name;
}

Player.prototype.play = function() {
	this.points += 1;
	mediator.played();
}

// Scoreboard
var scoreboard = {
	// updated HTML element
	element: document.getElementById('results'),
	// update display
	update: function(score) {
		var i, msg = '';
		for (i in score) {
			if (score.hasOwnProperty(i)) {
				msg += '<p><strong>' + i + '<\/strong>: ';
				msg += score[i];
				msg += '<\/p>';
			}
		}
		this.element.innerHTML = msg;
	}
}

// Mediator
var mediator = {
	// all players
	players: {},
	
	// initialize
	setup: function() {
		var players = this.players;
		players.home = new Player('Hosts');
		players.guest = new Player('Guests');
	},
	
	// ktos zagral uaktualnij wynikow
	played: function() {
		var players = this.players,
		score = {
			"Hosts": players.home.points,
			"Guests": players.guest.points
		};
		scoreboard.update(score);
	},
	
	// interaction with user
	keypress: function (e) {
		e = e || window.event; // IE
		if (e.which === 49) { // key "1"
			mediator.players.home.play();
			return;
		}
		
		if (e.which === 48) { // key "0"
			mediator.players.guest.play();
			return;
		}
	}
}

// start!
mediator.setup();
window.onkeypress = mediator.keypress;

// game finishes after 30 seconds
setTimeout(function() {
	window.onkeyprerss = null;
	alert('End of game!');
}, 30000);