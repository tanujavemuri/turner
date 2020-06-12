import React from 'react';
import { withStyles, Theme, createStyles, makeStyles } from '@material-ui/core/styles';
import Table from '@material-ui/core/Table';
import TableBody from '@material-ui/core/TableBody';
import TableCell from '@material-ui/core/TableCell';
import TableContainer from '@material-ui/core/TableContainer';
import TableHead from '@material-ui/core/TableHead';
import TableRow from '@material-ui/core/TableRow';
import Paper from '@material-ui/core/Paper';
import { PropTypes } from 'prop-types';

const StyledTableCell = withStyles((theme) =>
    createStyles({
        head: {
            backgroundColor: theme.palette.common.black,
            color: theme.palette.common.white,
        },
        body: {
            fontSize: 14,
        },
    }),
)(TableCell);

const StyledTableRow = withStyles((theme) =>
    createStyles({
        root: {
            '&:nth-of-type(odd)': {
                backgroundColor: theme.palette.action.hover,
            },
        },
    }),
)(TableRow);

function createData(name, calories, fat, carbs, protein) {
    return { name, calories, fat, carbs, protein };
}

const rows = [
    createData('Frozen yoghurt', 159, 6.0, 24, 4.0),
    createData('Ice cream sandwich', 237, 9.0, 37, 4.3),
    createData('Eclair', 262, 16.0, 24, 6.0),
    createData('Cupcake', 305, 3.7, 67, 4.3),
    createData('Gingerbread', 356, 16.0, 49, 3.9),
];

const useStyles = makeStyles({
    table: {
        minWidth: 700,
    },
});

export default function AwardDetail(props) {
    const classes = useStyles();
    console.log(props);
    return (
        <TableContainer component={Paper}>
            <Table className={classes.table} aria-label="customized table">
                <TableHead>
                    <TableRow>
                        {
                            props.tableHeaders.map(tableHeader => <StyledTableCell align={tableHeader.align}>{tableHeader.header}</StyledTableCell>)
                        }

                    </TableRow>
                </TableHead>
                <TableBody>
                    {props.rowData.map((row, index) => (
                        <StyledTableRow key={index}>
                            {props.tableHeaders.map((tableHeader, index) => <StyledTableCell align={tableHeader.align}>{tableHeader.dataType === "bool" ? (row[tableHeader.columnName] === true ? "Yes" : "No") : row[tableHeader.columnName]}</StyledTableCell>)

                            }
                        </StyledTableRow>
                    ))}
                </TableBody>
            </Table>
        </TableContainer>
    );
}
AwardDetail.prototype = {
    tableHeaders: PropTypes.Array,
    rowData: PropTypes.Array
}