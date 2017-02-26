var sectionIndex;
function getQueryVariable(variable)
{
       var query = window.location.search.substring(1);
       var vars = query.split("&");
       for (var i=0;i<vars.length;i++) {
                      var pair = vars[i].split("=");
                      if(pair[0] == variable){return pair[1];}
              }
       return(false);
}

function init(){
	sectionIndex = getQueryVariable("sectionIndex");
	console.log("Section Index = " + sectionIndex);
	if (!sectionIndex){sectionIndex = 1}
	showSection(parseInt(sectionIndex-1));
}


function getSections(){
	var sections = document.querySelectorAll("section");	
	return sections;
}


function showSection(sectionNum){ //sectionNum starts at 0
	var sections = getSections();
	if (sectionNum < 0 || isNaN(sectionNum)){window.location.href = "?sectionIndex=" + 1;}
	if (sectionNum > sections.length-1 ){window.location.href = "?sectionIndex=" + (sections.length)};
	console.log ("Found " + sections.length + " sections.")
	for (i=0;i<sections.length ;i++){
		if (i == sectionNum){
			sections[i].style.display = 'block';
			console.log ("Showing section " + i)
		}else{
			sections[i].style.display = 'none';
			console.log ("Hiding section " + i)
		} 
	}

	var nextButton = document.getElementById("nextButton");
	var prevButton = document.getElementById("prevButton");

	if (sectionNum == 0){
		console.log ("Prev button is type of " + typeof(prevButton));
		prevButton.disabled = true;
		console.log("First section - Disabling prev button.");
	}else{
		prevButton.disabled = false;
		console.log("Not first section - Enabling prev button");
	}
	if (sectionNum == sections.length-1){
		console.log("Last section - Disabling next button");
		nextButton.disabled = true;
	}else{
		console.log ("Not last section - Enabling next button")
		nextButton.disabled = false;
	}
	var lessonTitle = document.getElementById("lessonTitle");
	lessonTitle.innerText = lessonTitle.innerText + " (page " + (sectionIndex) + ")"
}

function nextSection(){
	sectionIndex++;
	window.location.href = "?sectionIndex=" + sectionIndex;
}
function prevSection(){
	sectionIndex--;
	window.location.href = "?sectionIndex=" + sectionIndex;
}

window.onload = function() {
	window.document.body.onload = init();
}