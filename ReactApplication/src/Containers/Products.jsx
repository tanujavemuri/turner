
import React, { Component } from 'react';
import "@babel/polyfill";
import Axios from 'axios';
import { AwardTableHeader, StoryLineTableHeader, OtherNameTableHeader } from './../../public/productJson';
import AwardDetail from './ProductDetail';


class Products extends Component {
    constructor(props) {
        super(props);
        this.state = {
            showDetail: false,
            title: '',
            awards: [],
            storyLines: [],
            otherNames: [],
            titles: []
        };
        this.showDetail = this.showDetail.bind(this);
        this.handleHideModal = this.handleHideModal.bind(this);
        this.clickHandler = this.clickHandler.bind(this);
        this.onChangeHandler = this.onChangeHandler.bind(this);
        this.dropdownChange = this.dropdownChange.bind(this);

    }

    handleHideModal() {
        this.setState({
            showDetail: false,
        })
    }
    showDetail(e) {

        this.setState({
            showDetail: true,
        })
    }
    onChangeHandler(evt) {
        this.setState({
            [evt.target.name]: evt.target.value
        })
    }
    async clickHandler() {
        try {
            const response = await Axios.get(`https://localhost:44328/GetMedia/TitlesName/${this.state.title}`);
            this.setState({
                awards: [],
                storyLines: [],
                otherNames: [],
                titles: response.data
            })

        } catch (error) {
            console.error(error);
        }

    }

    async dropdownChange(e) {
        try {
            const response = await Axios.get(`https://localhost:44328/GetMedia/${e.target.value}`);
            this.setState({
                awards: response.data.Award,
                storyLines: response.data.StoryLine,
                otherNames: response.data.OtherName,
            })

        } catch (error) {
            console.error(error);
        }

    }
    render() {

        return (

            <div className="row">

                <label>Name</label>
                <input type="text" value={this.state.title} onChange={this.onChangeHandler} name="title" ></input>
                <input type="button" value="Search" onClick={this.clickHandler} ></input>


                <br />
                <div style={{ marginLeft: "45px" }}>
                    <select onChange={this.dropdownChange}>
                        <option value="">Select Title</option>
                        {
                            this.state.titles.map(title => <option value={title.TitleName}>{title.TitleName}</option>)
                        }
                    </select>
                </div>
                <div style={{ marginTop: "15px" }}>
                    {this.state.awards.length > 0 &&
                        <AwardDetail
                            tableHeaders={AwardTableHeader}
                            rowData={this.state.awards}
                        />
                    }
                </div>
                <div style={{ marginTop: "15px" }}>
                    {this.state.storyLines.length > 0 &&
                        <AwardDetail
                            tableHeaders={StoryLineTableHeader}
                            rowData={this.state.storyLines}
                        />
                    }
                </div>
                <div style={{ marginTop: "15px" }}>
                    {this.state.otherNames.length > 0 &&
                        <AwardDetail
                            tableHeaders={OtherNameTableHeader}
                            rowData={this.state.otherNames}
                        />
                    }
                </div>

            </div >
        );
    }
}

export default Products;