/*do we need this?*/

function selectSearchType(searchType) {
    const form = document.getElementById('mainForm'); //we cant change value of the form

    //alert(searchType.value);

    const searchTypeSelection = document.getElementById('searchTypeSelected');

    searchTypeSelection.value = "C"; //we do it to control what's happening in the server

    form.submit(); //data will go to server
}

function changeSearchForm(searchType) {
    console.log(searchType.value);
}