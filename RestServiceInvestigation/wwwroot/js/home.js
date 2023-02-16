

$(document).ready(() => {

    let url = "/api/Members";

    fetch(url)
        .then((response) => response.json())
        .then((members) => {

            for (let member of members) {

                $('#tblMembers tbody').append(`
                <tr>
                    <td>${member.id}</td>
                    <td>${member.name}</td>
                    <td>${member.email}</td>
                    <td>${member.active ? "Active" : "Inactive"}</td>
                </tr>
            `);
            }
        });
  
});
