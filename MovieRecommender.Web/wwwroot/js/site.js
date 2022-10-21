function selectSearchType(searchType) {
    const form = document.getElementById('mainForm'); //we cant change value of the form

    //alert(searchType.value);

    const searchTypeSelection = document.getElementById('searchTypeSelected');

    searchTypeSelection.value = "C";

    form.submit(); //data will go to server
}